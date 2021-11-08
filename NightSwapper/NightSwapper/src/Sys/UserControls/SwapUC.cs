using NightSwapper.Properties;
using NightSwapper.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightSwapper.src.Sys.UserControls
{
    public partial class SwapUC : UserControl
    {
        public static long offset1 = 232;
        public static long offset2 = 100;
        public static long offset3 = 122;


        public SwapUC()
        {
            InitializeComponent();
            if (Settings.Default.check == "true")
            {
                RpcClass.client.UpdateDetails("Swapping " + this.Text);
            }
        }

        public static string hexCode1 = "";
        public static long off = 0;
        public static string pakStr = "";
        // New Pak File
        public static PakFile pak;
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            pak = new PakFile();
            pak.pakstr = "";
            SwapItem.Swap(0, ObjectConvert.HexToByteArray(hexCode1), SeekOrigin.Begin, pak);
        }
    }
}
