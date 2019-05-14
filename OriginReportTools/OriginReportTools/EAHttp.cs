using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Media.Imaging;
using System.Xml;

namespace OriginReportTools
{
    /// <summary>
    /// EA的官方网页API处理类
    /// </summary>
    class EAHttp
    {
        public class ReportFaildException : Exception
        {
            public ReportFaildException(string message) : base(message) { }
        }
        /// <summary>
        /// 玩家登陆后获得的Token
        /// </summary>
        public string Token;
        /// <summary>
        /// 玩家登陆后的邮箱
        /// </summary>
        public string Email;
        /// <summary>
        /// 玩家的EAID
        /// </summary>
        public string PlayerEAID;
        /// <summary>
        /// 玩家的EA名字
        /// </summary>
        public string PlayerName;

        public string HackerName;

        public string HackerEAID;


        /// <summary>
        /// 玩家的头像，执行GetMe方法后该内容就会自动获得
        /// </summary>
        public BitmapImage bitmapImage = new BitmapImage();

        /// <summary>
        /// 获取玩家账户信息的相关方法，需要先给Token才能正常获取
        /// </summary>
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
            bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(A);
            bitmapImage.DecodePixelWidth = 320;
            bitmapImage.EndInit();
            

        }
        /// <summary>
        /// 通过EAID获取玩家的头像地址
        /// </summary>
        /// <param name="ID">玩家的EAID</param>
        /// <returns></returns>
        private string ImgGet(string ID)
        {

            //return Imglink;//https://secure.download.dm.origin.com/production/avatar/prod/userAvatar/20486230/416x416.PNG

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
        /// <summary>
        /// 通过EAID得到玩家的名字，需要Token才能获取
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string IDGetName(string EAID)
        {
            String url = "https://api1.origin.com/atom/users?userIds=" + EAID;//url
            var handler = new HttpClientHandler() { UseCookies = false };
            var client = new HttpClient(handler);
            var message = new HttpRequestMessage(HttpMethod.Get, url);
            message.Headers.Add("authtoken", Token);
            var result = client.SendAsync(message);
            var rep = result.Result.Content.ReadAsStringAsync();
            string idGetNameXml = rep.Result;
            var doc = new XmlDocument();
            doc.LoadXml(idGetNameXml);
            XmlNode nobes = doc.SelectSingleNode("/users/user/EAID");
            string GameName = nobes.InnerText;
            return GameName;
        }

        /// <summary>
        /// 通过EAID获取主页链接
        /// </summary>
        /// <param name="EAID"></param>
        /// <returns></returns>
        public string IDgetLink(string EAID)
        {
            try
            {
                String url = "https://api1.origin.com/gifting/idobfuscate/users/" + EAID + "/encodePair";//url
                var handler = new HttpClientHandler() { UseCookies = false };
                var client = new HttpClient(handler);
                var message = new HttpRequestMessage(HttpMethod.Get, url);
                message.Headers.Add("authtoken", Token);
                var result = client.SendAsync(message);
                var rep = result.Result.Content.ReadAsStringAsync();
                string t = rep.Result;
                string[] s1 = t.Split('"');
                string Link = "https://www.origin.com/irl/zh-tw/profile/user/" + s1[3] + "/achievements";
                return Link;
            }
            catch
            {
                return null;
            }

        }
        /// <summary>
        /// 通过名字获取EAID
        /// </summary>
        /// <param name="GameName"></param>
        /// <returns></returns>

        public bool NameGetID(string GameName)
        {
            try
            {
                String url = "https://api3.origin.com/xsearch/users?userId=" + PlayerEAID + "&searchTerm=" + GameName + "&start=0";//url
                var handler = new HttpClientHandler() { UseCookies = false };
                var client = new HttpClient(handler);
                var message = new HttpRequestMessage(HttpMethod.Get, url);
                message.Headers.Add("authtoken", Token);
                var result = client.SendAsync(message);
                var rep = result.Result.Content.ReadAsStringAsync();
                string a = rep.Result;
                string[] s1 = a.Split('"');
                string ID = s1[7];
                HackerEAID = ID;
                return true;
            }
            catch
            {
                HackerEAID = null;
                return false;
            }
        }
        /// <summary>
        /// 发送举报给EA的文本
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>

        public bool ReportCheat(string comment)
        {
            string userId = PlayerEAID;
            //NameGetID(reportUsername);
            string reportId = HackerEAID;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string result = "";
            string url = string.Format("https://api2.origin.com/atom/users/{0}/reportUser/{1}", userId, reportId);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "text/plain;charset=UTF-8";
            req.Headers.Add("Origin", "https://www.origin.com");
            req.Headers.Add("X-Origin-Platform", "PCWIN");
            req.Headers.Add("AuthToken", Token);

            byte[] data = Encoding.UTF8.GetBytes(string.Format("<reportUser>\r\n<contentType>In Game</contentType>\r\n<reportReason>Cheating</reportReason>\r\n<comments>{0}</comments>\r\n</reportUser>", comment));
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            if (result == "<result>success</result>")
                return true;
            else
                throw new ReportFaildException(result);
        }


        public string UUID()
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = "/c \"wmic CPU get ProcessorID\"";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            string result = p.StandardOutput.ReadToEnd();
            string uuid = result.Split('\n')[1].Trim();
            uuid = uuid + getMacAddress();
            return uuid;
        }
        public string getMacAddress()
        {
            string macAddress = null;
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    if (adapter.NetworkInterfaceType.ToString().Equals("Ethernet")) //是以太网卡
                    {
                        string fRegistryKey = "SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\" + adapter.Id + "\\Connection";
                        RegistryKey rk = Registry.LocalMachine.OpenSubKey(fRegistryKey, false);
                        if (rk != null)
                        {
                            // 区分 PnpInstanceID     
                            // 如果前面有 PCI 就是本机的真实网卡    
                            // MediaSubType 为 01 则是常见网卡，02为无线网卡。    
                            string fPnpInstanceID = rk.GetValue("PnpInstanceID", "").ToString();
                            int fMediaSubType = Convert.ToInt32(rk.GetValue("MediaSubType", 0));
                            if (fPnpInstanceID.Length > 3 && fPnpInstanceID.Substring(0, 3) == "PCI") //是物理网卡
                            {
                                macAddress = adapter.GetPhysicalAddress().ToString();
                                break;
                            }
                            else if (fMediaSubType == 1) //虚拟网卡
                                continue;
                            else if (fMediaSubType == 2) //无线网卡(上面判断Ethernet时已经排除了)
                                continue;
                        }
                    }
                }
            }
            catch
            {
                macAddress = null;
            }
            return macAddress;
        }

        /// <summary>
        /// 获取网络日期时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetNetDateTime()
        {
            WebRequest request = null;
            WebResponse response = null;
            WebHeaderCollection headerCollection = null;
            DateTime dateTime = new DateTime();
            string time = string.Empty;
            try
            {
                request = WebRequest.Create("https://www.baidu.com");
                request.Timeout = 3000;
                request.Credentials = CredentialCache.DefaultCredentials;
                response = (WebResponse)request.GetResponse();
                headerCollection = response.Headers;
                foreach (var h in headerCollection.AllKeys)
                { if (h == "Date") { time = headerCollection[h]; } }
                dateTime = DateTime.Parse(time);
                dateTime = dateTime.ToUniversalTime();
                return dateTime;
            }
            catch (Exception) { return dateTime; }
            finally
            {
                if (request != null)
                { request.Abort(); }
                if (response != null)
                { response.Close(); }
                if (headerCollection != null)
                { headerCollection.Clear(); }
            }
        }


    }
}
