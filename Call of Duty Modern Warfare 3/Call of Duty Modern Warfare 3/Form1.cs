using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Call_of_Duty_Modern_Warfare_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Singleplayer-Coop.exe");
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Multiplayer.exe");
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Dedicated_Server.exe");
            Environment.Exit(0);
        }
    }
}
