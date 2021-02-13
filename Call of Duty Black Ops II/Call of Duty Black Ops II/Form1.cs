using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Call_of_Duty_Black_Ops_II
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            var ConfigFile = Path.GetFullPath("Redacted.ini");

            name.Text = IniFile.ReadValue(ConfigFile, "Steam", "Username");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSingleplayer_Click(object sender, EventArgs e)
        {
            var spdll    = Path.GetFullPath("data\\steam_api.dll_sp");
            var steamdll = Path.GetFullPath("steam_api.dll");

            if(File.Exists(steamdll))
            {
                File.Delete(steamdll);
            }

            File.Copy(spdll, steamdll);

            var ConfigFile = Path.GetFullPath("Redacted.ini");
            IniFile.WriteValue(ConfigFile, "Steam", "Username", " "+name.Text);

            Process.Start("t6sp.exe");
            Environment.Exit(0);
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            var mpdll       = Path.GetFullPath("data\\steam_api.dll_zmp");
            var steamdll    = Path.GetFullPath("steam_api.dll");
            var zoneplugin  = Path.GetFullPath("Plugins\\ZonePlugin.Red32n");
            var zonedisable = Path.GetFullPath("Plugins\\ZonePlugin.Red32n.disabled");

            if (File.Exists(steamdll))
            {
                File.Delete(steamdll);
            }

            File.Copy(mpdll, steamdll);

            if (File.Exists(zoneplugin))
            {
                File.Move(zoneplugin, zonedisable);
            }

            var ConfigFile = Path.GetFullPath("Redacted.ini");
            IniFile.WriteValue(ConfigFile, "Steam", "Username", " "+name.Text);

            // Backup profile
            System.IO.Directory.CreateDirectory(@"Plugins\OpenNetStorage\Userfiles\");
            String timestamp = DateTime.Now.ToString("yyyy-MMM-dd_hh-mm-ss");
            string startPath = @"Plugins\OpenNetStorage\Userfiles\";
            string zipPath = @"Plugins\OpenNetStorage\Backups\Automatic-" + timestamp + @".zip";
            ZipFile.CreateFromDirectory(startPath, zipPath);

            Process.Start("t6mp.exe");
            Environment.Exit(0);
        }

        private void btnZombies_Click(object sender, EventArgs e)
        {
            var mpdll       = Path.GetFullPath("data\\steam_api.dll_zmp");
            var steamdll    = Path.GetFullPath("steam_api.dll");
            var zoneplugin  = Path.GetFullPath("Plugins\\ZonePlugin.Red32n");
            var zonedisable = Path.GetFullPath("Plugins\\ZonePlugin.Red32n.disabled");

            if (File.Exists(steamdll))
            {
                File.Delete(steamdll);
            }

            File.Copy(mpdll, steamdll);

            if (File.Exists(zoneplugin))
            {
                File.Move(zoneplugin, zonedisable);
            }

            var ConfigFile = Path.GetFullPath("Redacted.ini");
            IniFile.WriteValue(ConfigFile, "Steam", "Username", " "+name.Text);

            Process.Start("t6zm.exe");
            Environment.Exit(0);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
