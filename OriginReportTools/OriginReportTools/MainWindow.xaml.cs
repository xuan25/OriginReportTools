using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace OriginReportTools
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginWindows loginWindows;
        string Token;
        string PlayerEAID;
        public MainWindow()
        {
            InitializeComponent();

            loginWindows = new LoginWindows();
            loginWindows.LoggedIn += LoginWindow_LoggedIn;
            loginWindows.LoggedOut += LoginWindow_LoggedOut;
            loginWindows.LoginCanceled += LoginWindow_LoginCanceled;
        }


        private void LoginWindow_LoggedIn(string token)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                LoginText.Text = "登陆成功";
                string[]A = token.Split('"');
                Token = A[3];
                LoginText.Text = "注销";
                GetMe();

            }));
        }

        private void LoginWindow_LoggedOut()
        {
            Dispatcher.Invoke(new Action(() =>
            {
                LoginText.Text = "Logged out";
            }));
        }

        private void LoginWindow_LoginCanceled()
        {
            Dispatcher.Invoke(new Action(() =>
            {
                LoginText.Text = "Login canceled";
            }));
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginText.Text == "登陆")
            {
                LoginText.Text = "载入中";
                loginWindows.Login();
            }
            else if (LoginText.Text == "注销")
            {
                LoginText.Text = "登陆";
                loginWindows.Logout();
                PlayerName.Text = "PlayerName";
                Email.Text = "PlayerEmail";
                IMG.Source = null;

            }
        }
        public void GetMe()
        {
            String url = "https://gateway.ea.com/proxy/identity/pids/me";//url
            var handler = new HttpClientHandler() { UseCookies = false };
            var client = new HttpClient(handler);

            var message = new HttpRequestMessage(HttpMethod.Get, url);
            message.Headers.Add("Authorization", "Bearer " + Token);
            var result = client.SendAsync(message);
            // result.EnsureSuccessStatusCode();
            //string a = result.Content.ReadAsStringAsync();
            var rep = result.Result.Content.ReadAsStringAsync();
            string a = rep.Result;
            //var lient = new RestClient("https://gateway.ea.com/proxy/identity/pids/me");
            //var equest = new RestRequest(Method.GET);
            //equest.AddHeader("Postman-Token", "230b06ce-6b85-4d86-a77e-727560d6910e");
            //equest.AddHeader("cache-control", "no-cache");
            //equest.AddHeader("Authorization", "Bearer "+token);
            //IRestResponse esponse = lient.Execute(equest);
            //Console.WriteLine(esponse.Content);

            //string a = esponse.Content;
            a = a.Replace("\"", "");
            a = a.Replace(" ", "");
            a = a.Replace("\n", "");

            string[] b = a.Split(',');
            string[] c = b[3].Split(':');
            Email.Text = c[1];
            string[] c1 = b[2].Split(':');
            PlayerEAID = c1[1];
            //CreatTime_L.Text = "创建时间:" + b[16].Replace("dateCreated:", "");
            PlayerName.Text = IDGetName(PlayerEAID);


            // string externalRefValue = studentsJson["pid"][0]["externalRefValue"].ToString();

            string A = ImgGet(PlayerEAID);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();  //给BitmapImage对象赋予数据的时候，需要用BeginInit()开始，用EndInit()结束
            bitmapImage.UriSource = new Uri(A);
            bitmapImage.DecodePixelWidth = 320;   //对大图片，可以节省内存。尽可能不要同时设置DecodePixelWidth和DecodePixelHeight，否则宽高比可能改变
            bitmapImage.EndInit();
            IMG.Source = bitmapImage;


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
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loginWindows.Close();
        }

        private void BF1_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(4f, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(0, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void BFV_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(0, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(4f, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void APEX_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(0, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(0, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(4f, 0, 0, 0);
        }
    }
}
