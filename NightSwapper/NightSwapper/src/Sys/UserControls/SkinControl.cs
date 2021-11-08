using NightSwapper.src.Cosmetics.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightSwapper.src.Sys.UserControls
{
    public partial class SkinControl : UserControl
    {
        public SkinControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new PinkGhoul().Show();
        }
    }
}
