using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetDNS
{
    public partial class DNS_Form : Form
    {
        public DNS_Form()
        {
            InitializeComponent();
        }

        public static NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
        {
            var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
                a => a.OperationalStatus == OperationalStatus.Up &&
                (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));

            return Nic;
        }
        public static void SetDNS(params string[] DnsString)
        {
            string[] Dns = DnsString;
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Description"].ToString().Equals(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = Dns;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }
        public static void UnsetDNS()
        {
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Description"].ToString().Equals(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = null;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }
        static void flushDNS()
        {
            string flushDnsCmd = @"/C ipconfig /flushdns";
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo("cmd.exe", flushDnsCmd)

                };
                process.Start();

                process.WaitForExit();
                Console.WriteLine(String.Format("Successfully Flushed DNS:'{0}'", flushDnsCmd), EventLogEntryType.Information);

            }
            catch (Exception exp)
            {
                Console.WriteLine(String.Format("Failed to Flush DNS:'{0}' . Error:{1}", flushDnsCmd, exp.Message), EventLogEntryType.Error);
            }
        }

        public List<string> GetLocalIPv4(NetworkInterfaceType _type)
        {
            List<string> output = new List<string>();
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces().Where(x => !x.Name.Contains("VM")))
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    if (item.GetIPProperties().IsDynamicDnsEnabled)
                    {
                        output.AddRange(item.GetIPProperties().DnsAddresses.Select(x => x.ToString()));
                    }
                }
            }
            return output;
        }

        private void btnShecan_Click(object sender, EventArgs e)
        {
            SetDNS("178.22.122.100", "185.51.200.2");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            UnsetDNS();
            flushDNS();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            SetDNS("8.8.8.8", "8.8.4.4");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            SetDNS("1.1.1.1", "1.0.0.1");
        }

        private void btnShowDNS_Click(object sender, EventArgs e)
        {
            var dns = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            if (dns.Count > 0)
            {
                MessageBox.Show("سرورهای زیر فعال هستند:\n\n" + string.Join("\n", dns), $"{dns.Count} سرور پیدا شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFlushDns_Click(object sender, EventArgs e)
        {
            flushDNS();
        }

        private void btn403_Click(object sender, EventArgs e)
        {
            SetDNS("10.202.10.202", "10.202.10.102");
        }

        private void btnCleanBrowsing_Click(object sender, EventArgs e)
        {
            SetDNS("185.228.168.168", "185.228.169.168");
        }
    }
}