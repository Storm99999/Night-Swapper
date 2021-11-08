using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSwapper.src.Classes
{
    class JsonReaderServiceProvider
    {
        public static string GetResult(string fileStr, string str)
        {
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(fileStr));

            return $"{jsonFile[str]}";
        }
    }
}
