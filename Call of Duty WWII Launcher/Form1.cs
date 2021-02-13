using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Call_of_Duty_WWII_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("s2_mp64_ship.exe");
            //p.StartInfo.Arguments = "--ip=";
            p.Start();
            Environment.Exit(0);
        }

        private void singleplayerButton_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("s2_sp64_ship.exe");
            //p.StartInfo.Arguments = "--ip=";
            p.Start();
            Environment.Exit(0);
        }

        private void zombiesButton_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("s2_mp64_ship.exe");
            p.StartInfo.Arguments = "+zombiesMode 1";
            p.Start();
            Environment.Exit(0);
        }
    }
}
