using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSwapper.src.Classes
{
    public class PakFile
    {
        public string pakstr = "";

        public string get()
        {
            // Return the pak string within a string.
            return pakstr.ToString();
        }
    }
}
