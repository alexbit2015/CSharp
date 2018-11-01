using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;

namespace AdminLauncher
{
   

    public partial class Form1 : Form
    {
        public void Marconmon()
        {
            string host = "10.136.136.41";
            string community = "public";
            SimpleSnmp snmp = new SimpleSnmp(host, community);

            if (!snmp.Valid)
            {
                label1.Text = "SNMP agent host name/ip address is invalid.";
                return;
            }
            Dictionary<Oid, AsnType> result = snmp.Get(SnmpVersion.Ver2, new string[] { ".1.3.6.1.4.1.476.1.42.3.9.20.1.20.1.2.1.5002" });
            if (result == null)
            {

                return;
            }

            foreach (var item in result.Values)
            {
                label1.Text = item.ToString();
            }
        }

    

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string connect_to_uamarterm001 = @"C:\Service\scripts\adminlauncher\rdp-mar-term001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uamarterm001);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connect_to_uamarsrvdb001 = @"C:\Service\scripts\adminlauncher\rdp-mar-srvdb001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uamarsrvdb001);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connect_to_uamarhpv001 = @"C:\Service\scripts\adminlauncher\rdp-mar-hpv001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uamarhpv001);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connect_to_uamarwww001 = @"C:\Service\scripts\adminlauncher\rdp-mar-www001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uamarwww001);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connect_to_uakhesrvdb001 = @"C:\Service\scripts\adminlauncher\rdp-khe-srvdb001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uakhesrvdb001);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connect_to_uablsrvdb001 = @"C:\Service\scripts\adminlauncher\rdp-bl-srvdb001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uablsrvdb001);


        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            string connect_to_uakhehpv001 = @"C:\Service\scripts\adminlauncher\rdp-khe-hpv001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uakhehpv001);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string connect_to_uablhpv002 = @"C:\Service\scripts\adminlauncher\rdp-bl-hpv002.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uablhpv002);


        }

        private void button11_Click(object sender, EventArgs e)
        {
            string connect_to_uamrgsrv001 = @"C:\Service\scripts\adminlauncher\rdp-mrg-srv001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uamrgsrv001);

        }

        private void button19_Click(object sender, EventArgs e)
        {

            string connect_to_uakhehpv002 = @"C:\Service\scripts\adminlauncher\rdp-khe-hpv002.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uakhehpv002);

        }

        private void button17_Click(object sender, EventArgs e)
        {

            string connect_to_uakhesrv001 = @"C:\Service\scripts\adminlauncher\rdp-khe-srv001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uakhesrv001);


        }

        private void button16_Click(object sender, EventArgs e)
        {
            string connect_to_uamarsrv001 = @"C:\Service\scripts\adminlauncher\rdp-mar-srv001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uamarsrv001);


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Marconmon();
            
        }

        private void InitializeTimer()
        {

            // Set to 1 second.  
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Enable timer.  
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text =  Alsnmpmon.ShowMarCondTemp();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string connect_to_uaazudev001 = @"C:\Service\scripts\adminlauncher\rdp-azu-dev001.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Unrestricted -File " + connect_to_uaazudev001);


        }
    }
}

