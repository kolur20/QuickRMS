using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuickRMS.Classes
{
    
    class QuickRun
    {

        const string NAME = "/name=";
        string name;
        public QuickRun(string arg)
        {
            ///arg   /name=name_client
            if (arg.Contains(NAME))
            {
                name = arg.Remove(0, NAME.Length + 1).ToLower();
            }
            else throw new ArgumentException($"Ошибка чтения аргумента: '{arg}'");
        }


        public void Start()
        {
            var servers = SqlManager.GetInstance().GetData()
                                    .Where(data => data.Name.ToLower().Contains(name));
            if (servers.Count() > 1) throw new ArgumentException($"Аргумент имеет не явный указатель на клиента: {name}");
            
            try
            {
                var server = servers.First();
                var process = new Process();
                var doc = new XmlDocument();
                process.StartInfo.FileName = Path.Combine(Properties.Settings.Default.PathRMSico, RMSico.GetName(server.Version, server.isChain));
                if (Properties.Settings.Default.AltRunRMS)
                {
                    process.StartInfo.Arguments = $"/AdditionalTmpFolder={Properties.Settings.Default.AltRunRMSFolder}";
                    var folder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\iiko\";
                    folder += server.isChain ? "Chain" : "Rms";
                    folder = $@"{folder}\{Properties.Settings.Default.AltRunRMSFolder}\config";

                    if (System.IO.File.Exists($@"{folder}\backclient.config.xml"))
                    {
                        var path = server.isChain ? "Chain" : "Rms";
                        path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\iiko\{path}\{Properties.Settings.Default.AltRunRMSFolder}\config";
                        Directory.CreateDirectory(path);
                        if (!File.Exists(Path.Combine(path, "backclient.config.xml")))
                        {
                            doc = new XmlDocument();
                            doc.LoadXml(Properties.Resources.backclient_config);
                            doc.Save(Path.Combine(path, "backclient.config.xml"));
                        }
                    }

                    doc = new XmlDocument();
                    doc.Load($@"{folder}\backclient.config.xml");
                    var elements = doc.DocumentElement.ChildNodes;

                    var str_connection = server.Connection.Split(':');
                    foreach (XmlNode serverInfo in elements)
                    {
                        if (serverInfo.Name == "ServersList")
                        {
                            var servInfoCurrent = serverInfo.ChildNodes;
                            foreach (System.Xml.XmlNode currentInfo in serverInfo)
                            {
                                if (currentInfo.Name == "ServerAddr")
                                {
                                    currentInfo.InnerText = str_connection[1].Remove(0, 2);
                                    continue;
                                }
                                if (currentInfo.Name == "Protocol")
                                {
                                    currentInfo.InnerText = str_connection.First();
                                    continue;
                                }
                                if (currentInfo.Name == "ServerSubUrl")
                                {
                                    currentInfo.InnerText = $@"/{server.Connection.Split('/').Last()}";
                                    continue;
                                }
                                if (currentInfo.Name == "Port")
                                    currentInfo.InnerText = str_connection[2].Remove(str_connection[2].LastIndexOf('/'));
                            }

                        }
                        if (serverInfo.Name == "Login")
                        {
                            serverInfo.InnerText = server.Login;
                            continue;
                        }
                    }
                    doc.Save($@"{folder}\backclient.config.xml");
                    
                }
                process.Start();
                process.WaitForExit(Properties.Settings.Default.TimeStart);
                SendKeys.SendWait(server.Password);
                
                SendKeys.SendWait("{ENTER}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + $": {name}");
            }



        }
        
    }
}
