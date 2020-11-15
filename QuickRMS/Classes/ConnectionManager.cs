
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml.Linq;
using HtmlAgilityPack;
using System.Xml;

namespace QuickRMS.Classes
{
    class ConnectionManager
    {
        public bool CheckConnection(string host)
        {
            try
            {
                var req = string.Format($"{host}/service/");
                SendRequest(req);
                
                return true;
            }
            catch (Exception)
            {
               return false;
            }
        }
        public class PrematureSolutionFound : Exception
        {

        }


        public void GetHtmlBrowser(string gethttp, string login, string password)
        {
            WebRequest webRequest = WebRequest.Create(gethttp);
            webRequest.Headers.Add("Accept-Language", "ru-RU");

            webRequest.Timeout = 5000;
            if (login != null && password != null)
                webRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(login + ":" + password)));
            WebResponse response1;
            response1 = webRequest.GetResponse();
            System.Diagnostics.Process.Start(response1.ResponseUri.AbsoluteUri);

            response1.Close();

        }
        public bool SkipLicence(string gethttp, string login, string password)
        {
            string script = HttpUtility.UrlEncode("import resto.licensing.LicenseService;LicenseService.releaseModuleConnections(200);");
            var req = string.Format($"{gethttp}/service/maintance/groovy.jsp?script={script}&action=start");
            SendRequest(req, login, password);
            return true;
        }
        public string SendRequest(string gethttp, string login = null, string password = null)
        {
            WebRequest webRequest = WebRequest.Create(gethttp);
            webRequest.Headers.Add("Accept-Language", "ru-RU");

            webRequest.Timeout = 5000;
            if (login != null && password != null)
                webRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(login + ":" + password)));
            WebResponse response1;
            try
            {
                response1 = webRequest.GetResponse();

            }
            catch (WebException ex)
            {
                string str = "";
                WebResponse response2 = ex.Response;
                if (response2 == null)
                    throw new Exception(ex.Message);
                using (Stream responseStream = response2.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        string end = new StreamReader(responseStream).ReadToEnd();
                        HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                        htmlDocument.LoadHtml(end);
                        str = htmlDocument.DocumentNode.Descendants("div").Aggregate<HtmlNode, string>(str, (Func<string, HtmlNode, string>)((current, item) => current + item.InnerText));
                    }
                }
                if (str == "")
                    str = ex.Message;
                throw new Exception(str);
            }
            Stream responseStream1 = response1.GetResponseStream();
            if (responseStream1 == null)
                return "";
            StreamReader streamReader = new StreamReader(responseStream1, Encoding.UTF8);
            string end1 = streamReader.ReadToEnd();

            streamReader.Close();
            responseStream1.Close();
            response1.Close();
            return end1;
        }
        public string CheckConnectionSafe(string host)
        {
            if (!host.Contains("/resto"))
                host += @"/resto";
            var req = string.Format($"{host}/service/");
            int del = 0;
            ///отрезаем протокол если он присутствует
            if (req.Contains("://"))
            {
                del = req.IndexOf(':');
                req = req.Remove(0, del);
            }
            else
            {
                req = "://" + req;
                host = "://" + host;
            }



            try
            {
                ///проверка присутствия портов
                if (req.Split(':').Count() > 2)
                {
                    try
                    {
                        SendRequest(@"http" + req);
                        host = @"http" + host.Remove(0, del);
                        throw new PrematureSolutionFound();
                    }
                    catch (PrematureSolutionFound) { throw new PrematureSolutionFound(); }
                    catch (Exception) { }
                    try
                    {
                        SendRequest(@"https" + req);
                        host = @"https" + host.Remove(0, del);
                        throw new PrematureSolutionFound();
                    }
                    catch (PrematureSolutionFound) { throw new PrematureSolutionFound(); }
                    catch (Exception) { }
                }
                ///порты отсутствуют
                else
                {
                    try
                    {
                        SendRequest(@"http" + req.Replace("/resto", ":8080/resto"));
                        host = @"http" + host.Remove(0, del).Replace("/resto", ":8080/resto");
                        throw new PrematureSolutionFound();
                    }
                    catch (PrematureSolutionFound) { throw new PrematureSolutionFound(); }
                    catch (Exception) { }
                    try
                    {
                        SendRequest(@"http" + req.Replace("/resto", ":9080/resto"));
                        host = @"http" + host.Remove(0, del).Replace("/resto", ":9080/resto");
                        throw new PrematureSolutionFound();
                    }
                    catch (PrematureSolutionFound) { throw new PrematureSolutionFound(); }
                    catch (Exception) { }
                    try
                    {
                        SendRequest(@"http" + req.Replace("/resto", ":80/resto"));
                        host = @"http" + host.Remove(0, del).Replace("/resto", ":80/resto");
                        throw new PrematureSolutionFound();
                    }
                    catch (PrematureSolutionFound) { throw new PrematureSolutionFound(); }
                    catch (Exception) { }
                    try
                    {
                        SendRequest(@"https" + req.Replace("/resto", ":443/resto"));
                        host = @"https" + host.Remove(0, del).Replace("/resto", ":443/resto");
                        throw new PrematureSolutionFound();
                    }
                    catch (PrematureSolutionFound) { throw new PrematureSolutionFound(); }
                    catch (Exception) { }
                }

            }
            catch (PrematureSolutionFound)
            {
                return host;
            }
            catch (Exception) { return host; }
            return host;

        }

        public string GetServerInfo(string host)
        {
            var req = string.Format($"{host}/get_server_info.jsp?encoding=UTF-8");
            var res = SendRequest(req);
            XElement root;
            try
            {
                root = XElement.Parse(res);
            }
            catch (Exception)
            {
                throw new Exception("Не удалось распарсить server_info");
            }
            var xElement = root.Element("serverName");
            return xElement != null ? xElement.Value : "";
        }


        public string GetServerVersion(string host)
        {
            var req = string.Format($"{host}/get_server_info.jsp?encoding=UTF-8");
            var res = SendRequest(req);
            XElement root;
            try
            {
                root = XElement.Parse(res);
            }
            catch (Exception)
            {
                throw new Exception("Не удалось распарсить server_info");
            }
            var xElement = root.Element("version");
            return xElement != null ? xElement.Value : "";
        }
        
    }
}
