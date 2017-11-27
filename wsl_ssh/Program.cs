using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsl_ssh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProcessStartInfo psi = new ProcessStartInfo("C:\\Windows\\System32\\bash.exe", "-c \"sudo service ssh start && sleep 999d\"");
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            //psi.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = Process.Start(psi);
            try
            {
                while (!p.HasExited)
                {
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                p.Kill();
            }
        }
    }
}
