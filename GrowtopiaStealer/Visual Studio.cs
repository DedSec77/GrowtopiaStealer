using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowtopiaStealer
{
    class Visual_Studio // https://github.com/TheC0mpany/GrowtopiaStealer
    {
        #region Visual Studio Paths
        public static string dirPathh = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Microsoft Visual Studio";
        #endregion
        public static void VisualStudioExistOrNo()
        {
            DirectoryInfo visualstudio = new DirectoryInfo(Path.Combine(dirPathh));
            // Stop if not exists
            if (!visualstudio.Exists)
                return;
            Counting.VisualStudio++;
        }
    }
}