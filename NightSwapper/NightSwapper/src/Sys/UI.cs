using NightSwapper.Properties;
using NightSwapper.src.Classes;
using NightSwapper.src.Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightSwapper
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            skinControl1.Hide();
            Settings.Default.paksDir = AutoPak.Grab(Settings.Default.paksDir);
            Settings.Default.Save();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            homepage1.Hide();
            skinControl1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            homepage1.Hide();
            skinControl1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            homepage1.Hide();
            skinControl1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            homepage1.Show();
            skinControl1.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            homepage1.Show();
            skinControl1.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            homepage1.Show();
            skinControl1.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\CustomData\\base.json"))
            { 
                // Set all of the hex codes by using the JsonReaderServiceProvider's GetResult method.
                CustomSwap.Title = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "title");
                // Parse the offset, we could of course use Convert.ToInt16 or something like that, but that's a pretty bad function/way.
                CustomSwap.off = long.Parse(JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "offset"));
                // And more JsonReaderServiceProviders
                CustomSwap.pakFile = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "pak1");
                CustomSwap.hexCode1R = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "hexCode1R");
                CustomSwap.hexCode1S = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "hexCode1S");
                CustomSwap.hexCode2R = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "hexCode2R");
                CustomSwap.hexCode2S = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "hexCode2S");
                CustomSwap.hexCode3R = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "hexCode3R");
                CustomSwap.hexCode3S = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "hexCode3S");
                CustomSwap.IconLoc = JsonReaderServiceProvider.GetResult(Application.StartupPath + "\\CustomData\\base.json", "imgLoc");
                new CustomSwap().Show();
            }
            else
            {
                // Show error
                MessageBox.Show("base.json does not exist.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customSwapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("CustomData");
            File.WriteAllText(Application.StartupPath + "\\CustomData\\base.json", new WebClient().DownloadString("https://pastebin.com/raw/nHbcQ9q5"));
            Process.Start(Application.StartupPath + "\\CustomData\\base.json");
        }
    }
}
