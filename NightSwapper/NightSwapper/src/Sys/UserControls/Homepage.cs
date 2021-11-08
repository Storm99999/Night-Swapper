using NightSwapper.Properties;
using NightSwapper.src.Classes;
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
    public partial class Homepage : UserControl
    {
        public Homepage()
        {
            InitializeComponent();

            if (Settings.Default.check == "")
            {

            }
            else
            {
                if (Settings.Default.check == "true")
                {
                    siticoneCheckBox1.Checked = true;
                    RpcClass.ActivateRPC("873488520298233896", "In-swapper.", "Join The Early Development", "https://youtube.com/you-suck", "On Homepage", "large", "Cool");
                }
                else
                {
                    siticoneCheckBox1.Checked = false;
                }
            }
        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox1.Checked == true)
            {
                Settings.Default.check = "true";
                Settings.Default.Save();
                RpcClass.ActivateRPC("873488520298233896", "In-swapper.", "Join The Early Development", "https://youtube.com/you-suck", "On Homepage", "large", "Cool");
                this.Refresh();
            }
            else
            {
                Settings.Default.check = "false";
                Settings.Default.Save();
                RpcClass.client.Dispose();
                this.Refresh();
            }
        }
    }
}
