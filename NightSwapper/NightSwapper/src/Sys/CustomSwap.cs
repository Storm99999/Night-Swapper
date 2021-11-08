// Import all usings
using NightSwapper.src.Classes;
using System;
using System.Windows.Forms;
using System.IO;

namespace NightSwapper.src.Sys
{
    public partial class CustomSwap : Form
    {
        public CustomSwap()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = IconLoc;
            label1.Text = Title;
        }

        public static string Title = "";
        public static long off = 9;
        public static string pakFile = "";
        public static string IconLoc = "";
        public static string hexCode1S = "";
        public static string hexCode1R = "";
        public static string hexCode2S = "";
        public static string hexCode2R = "";
        public static string hexCode3S = "";
        public static string hexCode3R = "";

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            PakFile pak = new PakFile();
            pak.pakstr = pakFile;
            SwapItem.Swap(off, ObjectConvert.HexToByteArray(hexCode1R), SeekOrigin.Begin, pak);
            SwapItem.Swap(off, ObjectConvert.HexToByteArray(hexCode2R), SeekOrigin.Begin, pak);
            SwapItem.Swap(off, ObjectConvert.HexToByteArray(hexCode3R), SeekOrigin.Begin, pak);
            richTextBox1.AppendText("\n[NIGHT] Suceeded Swapping Pak File " + pak.get());
        }

        private void CustomSwap_Load(object sender, EventArgs e)
        {

        }
    }
}
