using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightSwapper.src.Classes
{
    class AutoPak
    {
        // Check if dirs exist
        public static string GetDirectory()
        {
            if (Directory.Exists(@"C:\ProgramData\Epic"))
            {
                return @"C:\ProgramData\Epic";
            }
            if (Directory.Exists(@"D:\ProgramData\Epic"))
            {
                return @"D:\ProgramData\Epic";
            }
            if (Directory.Exists(@"E:\ProgramData\Epic"))
            {
                return @"E:\ProgramData\Epic";
            }
            if (Directory.Exists(@"F:\ProgramData\Epic"))
            {
                return @"F:\ProgramData\Epic";
            }
            return "Error: not found";
        }
        public static string Grab(string pakString) 
        {
            string EpicData = GetDirectory();
            if (File.Exists(EpicData + @"\UnrealEngineLauncher\LauncherInstalled.dat"))
            {
                var jsonObject = JObject.Parse(File.ReadAllText(EpicData + @"\UnrealEngineLauncher\LauncherInstalled.dat")); ///Format Json
                foreach (var Installs in jsonObject["InstallationList"])
                {
                    if (Directory.Exists(Installs["InstallLocation"] + @"\FortniteGame"))
                    {
                        return pakString = Installs["InstallLocation"] + @"\FortniteGame\Content\Paks";
                    }
                }
            }
            else
            {
                MessageBox.Show("Couldn't Find LauncherInstalled.dat Make Sure You Have Epic Games Installed!");
                return "error";
            }
            return "N/A";
        }
    }
}
