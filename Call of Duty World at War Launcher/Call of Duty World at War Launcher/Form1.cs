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

namespace Call_of_Duty_World_at_War_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void btnSingleplayer_Click(object sender, EventArgs e)
        {
            var dlllocation        = Path.GetFullPath("d3d9.dll");
            var dlldisablelocation = Path.GetFullPath("d3d9.dll_");

            // Enable the dll if it exists for singleplayer, this is to allow better mod support
            if (File.Exists(dlldisablelocation))
            {
                File.Move(dlldisablelocation, dlllocation);
            }
            Process.Start("CoDWaW.exe");
            Environment.Exit(0);
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            var dlllocation        = Path.GetFullPath("d3d9.dll");
            var dlldisablelocation = Path.GetFullPath("d3d9.dll_");

            //Rename the dll so that it's not active in Multiplayer, or it'll throw an error
            if (File.Exists(dlllocation))
            {
                File.Move(dlllocation, dlldisablelocation);
            }
            Process.Start("CoDWaWmp.exe");
            Environment.Exit(0);
        }

        private void btnOpenModFolder_Click(object sender, EventArgs e)
        {
            var LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

            Process.Start("explorer.exe", @LocalAppData+"\\Activision\\CoDWaW");
        }

        private void btnBots_Click(object sender, EventArgs e)
        {
            var source = new DirectoryInfo(Path.GetFullPath("mods"));

            var LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");
            var dest   = new DirectoryInfo(Path.GetFullPath(LocalAppData+"\\Activision\\CoDWaW\\mods"));

            // Make sure the dll is present otherwise some mods won't work
            if (!File.Exists("%LOCALAPPDATA%\\Activision\\CoDWaW\\mods\\mp_bots_pezbot\\PeZBOTWaW.iwd"))
            {
                CopyAll(source, dest);
            }

            // Install the mod
            
            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath("CoDWaWmp.exe");
            p.StartInfo.Arguments = "+set fs_game \"mods/mp_bots_pezbot\" +exec pezbot.cfg";
            p.Start();
            Environment.Exit(0);
        }
    }
}
