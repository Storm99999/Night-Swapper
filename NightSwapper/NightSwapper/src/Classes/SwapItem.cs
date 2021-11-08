using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightSwapper.src.Classes
{
    class SwapItem
    {
        public static void Swap(long off, byte[] bytesWritten, SeekOrigin origin, PakFile pak)
        {
            if (pak.get() == null)
            {
                MessageBox.Show("Error: Specified Pak file is null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileStream stream = File.Open(pak.get(), FileMode.Open, FileAccess.ReadWrite);
                BinaryWriter bin = new BinaryWriter(stream);
                bin.BaseStream.Seek(off, origin);
                bin.Write(bytesWritten);
                bin.Close();
            }
        }
    }
}
