using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Call_of_Duty_Advanced_Warfare_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("Ayria\\Assets\\Platformwrapper\\UserID.txt"))
            {
                var idtext   = "Ayria\\Assets\\Platformwrapper\\UserID.txt";
                PlayerIdBox.Text = File.ReadLines(idtext).First();

            }
            if (File.Exists("Ayria\\Assets\\Platformwrapper\\Username.txt"))
            {
                var nametext = "Ayria\\Assets\\Platformwrapper\\Username.txt";
                PlayerNameBox.Text = File.ReadLines(nametext).First();
            }

            if (File.Exists("Playlist\\data\\0000002c.pdo"))
            {
                var playlistText = "Playlist\\data\\0000002c.pdo";
                string pdoText = File.ReadAllText(playlistText);

                playlistTextbox.Text = pdoText;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Ayria\\Injector64.exe");
            p.StartInfo.Arguments = "s1_sp64_ship.exe";

            p.Start();
            Environment.Exit(0);
        }

        private void PlayerIdBox_TextChanged(object sender, EventArgs e)
        {
            var fileName = "Ayria\\Assets\\Platformwrapper\\UserID.txt";
            string lines = File.ReadAllText(fileName);
            lines.Replace("\r", "");
            File.WriteAllText(fileName, PlayerIdBox.Text);
        }

        private void PlayerNameBox_TextChanged(object sender, EventArgs e)
        {
            var fileName = "Ayria\\Assets\\Platformwrapper\\Username.txt";
            string lines = File.ReadAllText(fileName);
            lines.Replace("\r", "");
            File.WriteAllText(fileName, PlayerNameBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Ayria\\Injector64.exe");
            p.StartInfo.Arguments = "s1_mp64_ship.exe";

            p.Start();
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Ayria\\Injector64.exe");
            p.StartInfo.Arguments = "s1_mp64_ship.exe +survival 1";

            p.Start();
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Ayria\\Injector64.exe");
            p.StartInfo.Arguments = "s1_mp64_ship.exe +zombiesMode 1";

            p.Start();
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaylistUpdate_Click(object sender, EventArgs e)
        {
            // Save text to .pdo file
            var fileName = "Playlist\\data\\0000002c.pdo";
            File.WriteAllText(fileName, playlistTextbox.Text);

            // Delete original Playlist
            File.Delete("Ayria\\Assets\\Alwaysoffline\\5416\\Server\\playlists_tu22.aggr");

            // Copy template playlist
            File.Copy("Playlist\\playlists_tu22_template.aggr", "Ayria\\Assets\\Alwaysoffline\\5416\\Server\\playlists_tu22.aggr");

            // Run Offzip Compression
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Playlist\\offzip.exe");
            p.StartInfo.Arguments = "-a -r Ayria\\Assets\\Alwaysoffline\\5416\\Server\\playlists_tu22.aggr Playlist\\data";
            p.Start();
            p.WaitForExit();
            int result = p.ExitCode;

            if(result == 0)
            {
                MessageBox.Show("Updated Playlist");
            }

            if (result == 1)
            {
                MessageBox.Show("Playlist File too large, Resetting Defaults");
            }

            // Run zip program to create new playlist file
        }
    }
}
