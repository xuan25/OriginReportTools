using System;
using System.Net.Http;
using System.Windows.Media.Imaging;
using System.Xml;

namespace OriginReportTools
{
    class EAHttp
    {
        public string Token;
        public string Email;
        public string PlayerEAID;
        public string PlayerName;
        public BitmapImage bitmapImage = new BitmapImage();


        public void GetMe()
        {
            String url = "https://gateway.ea.com/proxy/identity/pids/me";//url
            var handler = new HttpClientHandler() { UseCookies = false };
            var client = new HttpClient(handler);
            var message = new HttpRequestMessage(HttpMethod.Get, url);
            message.Headers.Add("Authorization", "Bearer " + Token);
            var result = client.SendAsync(message);
            var rep = result.Result.Content.ReadAsStringAsync();
            string a = rep.Result;
            a = a.Replace("\"", "");
            a = a.Replace(" ", "");
            a = a.Replace("\n", "");
            string[] b = a.Split(',');
            string[] c = b[3].Split(':');
            Email = c[1];
            string[] c1 = b[2].Split(':');
            PlayerEAID = c1[1];
            PlayerName = IDGetName(PlayerEAID);
            string A = ImgGet(PlayerEAID);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(A);
            bitmapImage.DecodePixelWidth = 320;
            bitmapImage.EndInit();


        }

        private string ImgGet(string ID)
        {

            //return Imglink;//

            String url = "https://api1.origin.com/avatar/user/" + ID + "/avatars?size=1";//url
            var handler = new HttpClientHandler() { UseCookies = false };
            var client = new HttpClient(handler);

            var message = new HttpRequestMessage(HttpMethod.Get, url);
            message.Headers.Add("authtoken", Token);
            var result = client.SendAsync(message);
            var rep = result.Result.Content.ReadAsStringAsync();
            string idGetNameXml = rep.Result;
            var doc = new XmlDocument();
            doc.LoadXml(idGetNameXml);
            XmlNode nobes = doc.SelectSingleNode("/users/user/avatar/link");
            string Imglink = nobes.InnerText;
            return Imglink;
        }
        public string IDGetName(string ID)
        {
            String url = "https://api1.origin.com/atom/users?userIds=" + ID;//url
            var handler = new HttpClientHandler() { UseCookies = false };
            var client = new HttpClient(handler);

            var message = new HttpRequestMessage(HttpMethod.Get, url);
            message.Headers.Add("authtoken", Token);
            var result = client.SendAsync(message);
            // result.EnsureSuccessStatusCode();
            //string a = result.Content.ReadAsStringAsync();
            var rep = result.Result.Content.ReadAsStringAsync();
            string idGetNameXml = rep.Result;

            var doc = new XmlDocument();
            doc.LoadXml(idGetNameXml);
            XmlNode nobes = doc.SelectSingleNode("/users/user/EAID");
            string GameName = nobes.InnerText;
            return GameName;
        }

    }
}
