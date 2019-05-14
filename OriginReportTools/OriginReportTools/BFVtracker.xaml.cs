using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OriginReportTools
{
    /// <summary>
    /// BFtracker.xaml 的交互逻辑
    /// </summary>
    public partial class BFVtracker : Window
    {
        string str;
        string Name;
        string Regex1;
        string Regex2;
        string WebLink;
        string Token;
        string EndRead;
        List<Data> B;
        
        int b;

        public BFVtracker(string PlayerName,string token)
        {
            InitializeComponent();
            Title = PlayerName+"-战绩查询工具";
            Name = PlayerName;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.CanUserAddRows = true;

            DataGridClass.AutoGenerateColumns = false;
            DataGridClass.CanUserAddRows = true;
            //Task<List<Data>> Weapon = GetData(Type.Weapons);
            //  Task<bool> wait = GetData(Type.Overview);
            GetData();
           

            //Task<List<Data>> vehicles = GetData(Type.vehicles);
            //Task<List<Data>> Class = GetData(Type.Class);

        }

        public async Task GetData()
        {
            bool wait = await GetData(Type.Overview);
           // bool wait1 = await GetData(Type.Class);
            //bool wait2 = await GetData(Type.Weapons);




        }




        public enum Type
        {
            Overview,

            Class,

            Weapons,

            vehicles,

            JSON

        }
        public async Task <bool> GetData(Type type)
        {
            switch (type)
            {
                case Type.Overview:
                    WebLink = "overview";
                    Regex1 = "<span class=\"value\" data-v-abae987e>";
                    Regex2 = "<span class=\"rank\" data-v-abae987e>";
                    b = 0;
                    break;

                case Type.Class:
                    WebLink = "overview";
                    Regex1 = "<span class=\"name\" data-v-05d7549d data-v-2785eb0c>";
                    Regex2 = "<span class=\"sub\" data-v-05d7549d data-v-2785eb0c>";
                    b = 1;
                    break;

                case Type.Weapons:
                    WebLink = "weapons";
                    Regex1 = "<span class=\"name\" data-v-05d7549d data-v-ae988792>";
                    Regex2 = "<span class=\"sub\" data-v-05d7549d data-v-ae988792>";
                    b = 0;
                    break;

                case Type.vehicles:
                    WebLink = "vehicles";
                    Regex1 = "<span class=\"name\" data-v-05d7549d data-v-65ae7756>";
                    Regex2 = "<span class=\"sub\" data-v-05d7549d data-v-65ae7756>";
                    b = 0;
                    break;


            }
            WebRequest request = WebRequest.Create(string.Format("https://battlefieldtracker.com/bfv/profile/origin/{0}/{1}", Name, WebLink));
            WebResponse response = await request.GetResponseAsync();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8"));

            EndRead = reader.ReadToEnd();
            GetInfo();
            GetImg();
            Regex rg1 = new Regex("(?<=(" + Regex1 + "))[.\\s\\S]*?(?=(</span>))", RegexOptions.Multiline | RegexOptions.Singleline);
            Regex rg2 = new Regex("(?<=(" + Regex2 + "))[.\\s\\S]*?(?=(</span>))", RegexOptions.Multiline | RegexOptions.Singleline);
            Regex rg3 = new Regex("(?<=__INITIAL_STATE__=)(.+?)(?=;)", RegexOptions.Multiline | RegexOptions.Singleline);
            foreach (Match a in rg3.Matches(EndRead))
            {
                A.Add(a.Value);
            }
            List<string> A = new List<string>();
            List<string> B = new List<string>();
            switch (type)
            {
                case Type.Overview:
                    A.Clear();
                    B.Clear();
                    List<PlayerTotal> A1 = new List<PlayerTotal>();
                    List<PlayerTotal> A2 = new List<PlayerTotal>();
                    foreach (Match a in rg1.Matches(EndRead))
                    {
                        A.Add(a.Value);
                    }
                    A2.Add(new PlayerTotal(A));
                    foreach (Match a in rg2.Matches(EndRead))
                    {
                        B.Add(a.Value);
                    }
                    b = 0;
                    A1.Add(new PlayerTotal(A));
                    A1.Add(new PlayerTotal(B));
                    DataGrid.ItemsSource = A2;
                    break;

                case Type.Class:
                    
                    A.Clear();
                    B.Clear();
                    List<Class> C1 = new List<Class>();
                    List<Class> C2 = new List<Class>();
                    foreach (Match a in rg1.Matches(EndRead))
                    {
                        A.Add(a.Value);
                    }
                    A.RemoveAt(0);
                    foreach (Match a in rg2.Matches(EndRead))
                    {
                        B.Add(a.Value);
                    }
                    int cp = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        
                        C1.Add(new Class(A, cp));
                        C1.Add(new Class(B, cp));
                        cp += 7;
                    }
                    cp = 0;
                    for (int i = 0; i < 6; i++)
                    {

                        C2.Add(new Class(A, cp));
                        cp += 7;
                    }
                    DataGridClass.ItemsSource = C2;
                    break;

                case Type.Weapons:
                    WebLink = "weapons";
                    Regex1 = "<span class=\"name\" data-v-05d7549d data-v-ae988792>";
                    Regex2 = "<span class=\"sub\" data-v-05d7549d data-v-ae988792>";
                    b = 0;
                    break;

                case Type.vehicles:
                    WebLink = "vehicles";
                    Regex1 = "<span class=\"name\" data-v-05d7549d data-v-65ae7756>";
                    Regex2 = "<span class=\"sub\" data-v-05d7549d data-v-65ae7756>";
                    b = 0;
                    break;
            }
            return true;
        }

        private void GetImg()
        {
            string Regex3 = "data-v-62b8b5d8><!----> <img src=\"";
            string Regex4 = "\" data-v-62b8b5d8></a></div> <a href=\"";
            string e1 = GetValue(EndRead, Regex3, Regex4);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(e1);
            bitmapImage.DecodePixelWidth = 320;
            bitmapImage.EndInit();
            Img.Source = bitmapImage;


        }

        private void GetInfo()
        {
           string a = "</h2> <div class=\"header-stats\" data-v-05d7549d data-v-332bc279><span class=\"playtime\" data-v-05d7549d data-v-332bc279>";
           string b = "</span> <span class=\"last-played\" data-v-05d7549d data-v-332bc279";
           string er= GetValue(EndRead, a, b);
            a = "></path></svg>\n";
            b = "Play Time";
            er= GetValue(er, a, b);

            //er = er.Replace("d","天");
            //er = er.Replace("h", "小时");
            //er = er.Replace("m", "分钟");
            string[] day = er.Split('d');
            string[] H = day[1].Split('h');
            string[] M = H[1].Split('m');
            double Time = double.Parse(day[0])*24+ double.Parse(H[0])+ double.Parse(M[0])/60;


            PlayTime.Text= "["+Math.Round(Time,1) +"小时]";
            a = "Last Played ";
            b = "</span></div></header> <div class=\"main\"";
            er = GetValue(EndRead, a, b);
            er = er.Replace("/r", "");
            LastPlayTime.Text ="["+ er.Trim()+"]";


        }



        public static string GetValue(string str, string s, string e)
        {
            Regex rg = new Regex("(?<=(" + s + "))[.\\s\\S]*?(?=(" + e + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(str).Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //public List<Data> GetValue(string str, string s1,string s2)
        //{



        //    foreach (Match a in rg1.Matches(str))
        //    {

        //        Data aa = new Data();
        //        aa.Name=a.Value;
        //        aa.Rank = rg2.Matches(str)[b].Value;
        //        ls.Add(aa);
        //        b++;

        //    }

        //    return ls;
        //}


    }

    public class Data
    {
       public string Name { get; set; }
       public string Rank { get; set; }
    }

    public class PlayerTotal
    {
        public String Score_min { get; set; }
        public String KD { get; set; }
        public String Rank { get; set; }
        public String winP { get; set; }
        public String Kill { get; set; }
        public String KPM { get; set; }
        public String Wins { get; set; }
        public String Deaths { get; set; }
        public String Assists { get; set; }
        public String Damage { get; set; }
        public String Heals { get; set; }
        public String Revives { get; set; }
        public String Resupplies { get; set; }

        public PlayerTotal(List<string> A)
        {
            Score_min = A[0];
            KD = A[1];
            Rank = A[2];
            winP = A[3];
            Kill = A[6];
            KPM = A[7];
            Wins = A[9];
            Deaths = A[10];
            Assists = A[11];
            Damage = A[12];
            Heals = A[13];
            Revives = A[14];
            Resupplies = A[15];
        }
    }
    public class Class
    {
        public string ClassName{get; set;}
        public string Score { get; set; }
        public string Score_min { get; set; }
        public string KD { get; set; }
        public string Rank { get; set; }

        public string Kill { get; set; }
        public string KPM { get; set; }


        public Class(List<string> A,int i)
        {
            ClassName = A[i++];
            Rank = A[i++];
            Score = A[i++];
            Score_min = A[i++];
            Kill = A[i++];
            KPM = A[i++];
            KD = A[i++];
        }

    }
}
