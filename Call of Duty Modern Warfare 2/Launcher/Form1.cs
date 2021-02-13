using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Form1 : Form
    {
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ConfigFile = Path.GetFullPath("alterIWnet.ini");

            var Savedip = IniFile.ReadValue(ConfigFile, "Configuration", "Server");
            hostIP.Text = Savedip;

            playerName.Text = IniFile.ReadValue(ConfigFile, "Configuration", "Nickname");
        }

        private void hostIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSingleplayer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iw4sp.exe");
            Environment.Exit(0);
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            var runningProcessByName = System.Diagnostics.Process.GetProcessesByName("IWNetServer");
            if (runningProcessByName.Length == 0)
            {
                System.Diagnostics.Process.Start("IWNetServer.exe");
            }
            System.Diagnostics.Process.Start("iw4mp.exe");
            Environment.Exit(0);
        }

        private void btnCoop_Click(object sender, EventArgs e)
        {
            var ConfigFile = Path.GetFullPath("alterIWnet.ini");
            var Savedip    = IniFile.ReadValue(ConfigFile, "Configuration", "Server");
            var CurrentIP  = GetLocalIPAddress();

            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("TeknoGods_MW2SP.exe");

            if (Savedip != CurrentIP)
            {
                p.StartInfo.Arguments = "--ip=" + Savedip;
            }

            p.Start();
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var ConfigFile = Path.GetFullPath("alterIWnet.ini");
            IniFile.WriteValue(ConfigFile, "Configuration", "Server", hostIP.Text);
            IniFile.WriteValue(ConfigFile, "Configuration", "Nickname", playerName.Text);
        }

        private void GetMyIP_Click(object sender, EventArgs e)
        {
            hostIP.Text = GetLocalIPAddress();
            var ConfigFile = Path.GetFullPath("alterIWnet.ini");
            IniFile.WriteValue(ConfigFile, "Configuration", "Server", hostIP.Text);
        }

        private void playerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
