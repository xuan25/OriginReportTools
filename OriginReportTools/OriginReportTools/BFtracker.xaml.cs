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
    public partial class BFtracker : Window
    {
        string str;
        string Name;
        string Regex1;
        string Regex2;
        string WebLink;
        List<Data> B;
        
        int b;

        public BFtracker( string PlayerName)
        {
            InitializeComponent();
            Name = PlayerName;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.CanUserAddRows = true;
            //Task<List<Data>> Weapon = GetData(Type.Weapons);
            Task<List<Data>> Overview = GetData(Type.Overview);

            //Task<List<Data>> vehicles = GetData(Type.vehicles);
            //Task<List<Data>> Class = GetData(Type.Class);

        }




        public enum Type
        {
            Overview,

            Class,

            Weapons,

            vehicles,

        }
        public async Task<List<Data>> GetData(Type type)
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
            string EndRead = reader.ReadToEnd();
            Regex rg1 = new Regex("(?<=(" + Regex1 + "))[.\\s\\S]*?(?=(</span>))", RegexOptions.Multiline | RegexOptions.Singleline);
            Regex rg2 = new Regex("(?<=(" + Regex2 + "))[.\\s\\S]*?(?=(</span>))", RegexOptions.Multiline | RegexOptions.Singleline);
            List<Data> ls = new List<Data>();
            List<string> A = new List<string>();
            
            List<string> B = new List<string>();

            List<PlayerTotal> A1 = new List<PlayerTotal>();

            
            foreach (Match a in rg1.Matches(EndRead))
            {
                
                // Data aa = new Data();
                A.Add(a.Value);
                B.Add(rg2.Matches(EndRead)[b].Value);
                // ls.Add(aa);

                b++;
            }
            A1.Add(new PlayerTotal(A));
            A1.Add(new PlayerTotal(B));
            DataGrid.ItemsSource = A1;
            return ls;
           
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
}
