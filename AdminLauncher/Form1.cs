using System;
using System.Collections.Generic;
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
            label11condTemp.Text = "proccessing";
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
                
                label11condTemp.Text = item.ToString();
            }
        }

     

        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Marconmon();
            

        }

        private void InitializeTimer()
        {

            // Set to 1 second.  
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            timer1.Enabled = true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();

        }

        private void RdpConnect(string scriptname)
        {
            ServersChecker sc = new ServersChecker();
            sc.RdpConnect(scriptname);
        }

        private void RunHttpLink (string link)
        {
            ServersChecker sc = new ServersChecker();
            sc.RunHttpLink(link);
        }


        
        private void button3_Click(object sender, EventArgs e)
        {
            
            RdpConnect("rdp-mar-hpv001");           

        }

        private void Button2uamarsrvdb001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-mar-srvdb001");

        }

        private void button12uamrgsrvdb001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-mrg-srvdb001");
        }

        private void button7uakhesrvdb001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-khe-srvdb001");
        }

        private void button8uablsrvdb001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-bl-srvdb001");
        }

        private void button16uamarsrv001_Click(object sender, EventArgs e)
        {
            
            RdpConnect("rdp-mar-srv001");
        }

        private void button5uamarhpv003_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-mar-hpv003");
        }

        private void button2kzsmihpv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-smi-hpv001");

        }

        private void button10uamrghpv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-mrg-hpv001");
        }

        private void button18uakhehpv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-khe-hpv001");
        }

        private void button26kzdensrvdb001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-kzden-srvdb001");
        }

        private void button25kzdenonc001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-kzden-onc001");
        }

        private void button23kzdenhpv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-kzden-hpv001");
        }

        private void button6uamarwww001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-mar-www001");
        }

        private void button1uamarterm001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-mar-term001");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-bl-srv002");
        }

        private void button13uablhpv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-bl-hpv001");
        }

        private void button14uablhpv002_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-bl-hpv002");
        }

        private void button4uamarhpv002_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-mar-hpv002");
        }

        private void button11uamrgsrv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-mrg-srv001");
        }

        private void button20uablsecsrv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-bl-sec001");
        }

        private void button19uakhehpv002_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-khe-hpv002");
        }

        private void button17uakhesrv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-khe-srv001");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RunHttpLink("http://google.com");
        }

        private void button8runServiceNow_Click(object sender, EventArgs e)
        {
            RunHttpLink("https://cofcointernational.service-now.com/nav_to.do");
            
        }

        private void button9runSolarWinds_Click(object sender, EventArgs e)
        {
            RunHttpLink("https://solarwinds.cofcointernational.com/Orion/Login.aspx?ReturnUrl=%2f");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-smi-srvdb001");
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void button12mrgidrac_Click(object sender, EventArgs e)
        {
            RunHttpLink("http://#");
        }

        private void button12idracMarR730_Click(object sender, EventArgs e)
        {
            RunHttpLink("https://10.136.136.149/index.html");
        }

        private void button12MarHp725_Click(object sender, EventArgs e)
        {
            RunHttpLink("https://10.136.136.45/"); 

        }

        private void button12citrix_Click(object sender, EventArgs e)
        {
            RunHttpLink("https://citrix.cofcointernational.com/Citrix/ProductionWeb/");
        }

        private void button17AsusStor6Tb_Click(object sender, EventArgs e)
        {
            RunHttpLink("http://10.136.136.222:8000");
        }

        private void button18uablhpv001idrac_Click(object sender, EventArgs e)
        {
            RunHttpLink("https://10.136.224.10/index.html");
            
        }

        private void button19kievsrvdb_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-iev-srvdb001");
        }

        private void button7ievhv001_Click(object sender, EventArgs e)
        {
            RdpConnect("rdp-iev-hpv001");
        }
    }
}

