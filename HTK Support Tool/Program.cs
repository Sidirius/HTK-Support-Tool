using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace HTK_Support_Tool
{
    internal static class Program
    {
        /// <summary>
        ///     Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form mainGui = new MainGui();
            Application.Run(mainGui);
        }

        public static string GetIp4Address()
        {
            var ip4Address = String.Empty;

            foreach (var ipa in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ipa.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip4Address = ipa.ToString();
                    break;
                }
            }

            return ip4Address;
        }

        public static string GetFqdn()
        {
            var domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
            var hostName = Dns.GetHostName();

            if (!hostName.EndsWith(domainName)) // if hostname does not already include domain name
            {
                hostName += "." + domainName; // add the domain name part
            }

            return hostName; // return the fully qualified name aaa
        }
    }
}