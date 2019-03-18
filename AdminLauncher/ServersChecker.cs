using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdminLauncher
{
    class ServersChecker
    {
        public void RdpConnect(string scriptname)
        {
            string connect_to_server_script = @"C:\Service\scripts\adminlauncher\"+scriptname+".ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_server_script);
        }

        public string SqlBackupCheck(string servername)
        {

            return null;
        }

      

    }
}
