using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickRMS.Forms;

namespace QuickRMS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            if (hasAdministrativeRight == false)
            {
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.Verb = "runas";
                processInfo.FileName = Application.ExecutablePath;
                try
                {
                    Process.Start(processInfo);
                }
                catch (Win32Exception)
                {

                }
                Application.Exit();
            }
            else
            {
                if (Environment.GetCommandLineArgs().Count() > 1)
                {
                    try
                    {
                        var run = new Classes.QuickRun(Environment.CommandLine.Remove(0, Environment.GetCommandLineArgs()[0].Length+1));
                        run.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка QuickRMS.exe");
                    }
                    Application.Exit();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());

                }
            }
        }
    }
}
