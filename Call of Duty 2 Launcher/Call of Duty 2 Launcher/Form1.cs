using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Call_of_Duty_2_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSingleplayer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CoD2SP_s.exe");
            Environment.Exit(0);
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CoD2MP_s.exe");
            Environment.Exit(0);
        }

        private void btnBots_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("CoD2MP_s.exe");
            p.StartInfo.Arguments = "+set fs_game mbotsoundfinal +exec mbotsoundfinal.cfg";
            p.Start();
            Environment.Exit(0);
        }

        private void btnWaypoint_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("CoD2MP_s.exe");
            p.StartInfo.Arguments = "+set fs_game botdev +exec botDev.cfg";
            p.Start();
            Environment.Exit(0);
        }
    }
}
