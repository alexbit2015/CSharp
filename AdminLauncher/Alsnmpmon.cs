using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;


namespace AdminLauncher
{
    class Alsnmpmon
    {
        public static string ShowMarCondTemp()
        {
                string host = "10.136.136.41";
                string community = "public";
                SimpleSnmp snmp = new SimpleSnmp(host, community);
                string temperature;

                if (!snmp.Valid)
                {
                
                temperature = "SNMP agent host name/ip address is invalid.";
                  
                }
                Dictionary<Oid, AsnType> result = snmp.Get(SnmpVersion.Ver2, new string[] { ".1.3.6.1.4.1.476.1.42.3.9.20.1.20.1.2.1.5002" });
                if (result == null)
                {

                temperature = "Result is NULL";
                }

                //foreach (var item in result.Values)
                //{
                //    temperature = float.Parse(item.ToString());
                
                //}
                temperature = result.Values.ToString();
                return temperature;

                
            
        }
     
    }
}
