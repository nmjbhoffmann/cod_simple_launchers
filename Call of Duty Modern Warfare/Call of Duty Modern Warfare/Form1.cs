using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Call_of_Duty_Modern_Warfare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brnSingleplayer_Click(object sender, EventArgs e)
        {
            Process.Start("iw3sp.exe");
            Environment.Exit(0);
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            Process.Start("iw3mp.exe");
            Environment.Exit(0);
        }

        private void btnBots_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath("iw3mp.exe");
            p.StartInfo.Arguments = "+set fs_game \"mods/Bots_PeZBOT\" +exec pezbot.cfg";
            p.Start();
            Environment.Exit(0);
        }

        private void btnZombies_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath("iw3mp.exe");
            p.StartInfo.Arguments = "+set fs_game \"Mods/Zombies_ROTD\" +set sv_punkbuster 0 +set sv_maxclients 32 +exec rotu.cfg";
            p.Start();
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
