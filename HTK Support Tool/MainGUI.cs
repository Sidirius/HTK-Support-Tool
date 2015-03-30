using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace HTK_Support_Tool
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
            lblComputername.Text = Environment.MachineName;
            lblDomain.Text = IPGlobalProperties.GetIPGlobalProperties().DomainName;
            lblComputerIP.Text = Program.GetIp4Address();
            lblFqdn.Text = Program.GetFqdn();
            cbOLInstalled.Checked = Program.IsOlInstalled();
            if (Program.IsOlInstalled())
            {
                cbOLInstalled.ForeColor = System.Drawing.ColorTranslator.FromHtml("#298A08");
            }
        }

        private void lblComputerIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblComputerIP.Text);
        }

        private void lblComputerIP_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c ping -t -a " + lblComputerIP.Text);
        }

        private void lblComputername_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblComputername.Text);
        }

        private void lblDomain_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblDomain.Text);
        }

        private void lblFqdn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblFqdn.Text);
        }

        private void lblFqdn_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c ping -t " + lblFqdn.Text);
        }

        private void neuStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}