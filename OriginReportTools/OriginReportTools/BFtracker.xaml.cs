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

        public BFtracker()
        {
            InitializeComponent();
            Name ="GenesisaAN";
            List<Data> Ove = GetData(Type.Overview);
        }


        public enum Type
        {
            Overview,

            Class,

            Weapons,

            vehicles,

        }
        public List<Data> GetData(Type type)
        {
            switch (type)
            {
                case Type.Overview:
                    WebLink = "overview";
                    Regex1 = "<span class=\"value\" data-v-abae987e>";
                    Regex2 = "<span class=\"rank\" data-v-abae987e>";
                    break;

                case Type.Class:
                    WebLink = "overview";
                    Regex1 = "<span class=\"name\" data-v-05d7549d data-v-2785eb0c>";
                    Regex2 = "<span class=\"sub\" data-v-05d7549d data-v-2785eb0c>";
                    break;

                case Type.Weapons:
                    WebLink = "weapons";
                    Regex1 = "<span class=\"name\" data-v-05d7549d data-v-ae988792>";
                    Regex2 = "<span class=\"sub\" data-v-05d7549d data-v-ae988792>";
                    break;

                case Type.vehicles:
                    WebLink = "vehicles";
                    Regex1 = "<span class=\"name\" data-v-05d7549d data-v-65ae7756>";
                    Regex2 = "<span class=\"sub\" data-v-05d7549d data-v-65ae7756>";
                    break;

                default:
                    WebLink = "overview";
                    Regex1 = "<span class=\"value\" data-v-abae987e>";
                    Regex2 = "<span class=\"rank\" data-v-abae987e>";
                    break;
                   
            }
            WebRequest request = WebRequest.Create(string.Format("https://battlefieldtracker.com/bfv/profile/origin/{0}/{1}", Name, WebLink));
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
            List <Data> ls = GetValue(reader.ReadToEnd(),Regex1,Regex2);
            return ls;
        }

        public static List<Data> GetValue(string str, string s1,string s2)
        {
            Regex rg1 = new Regex("(?<=(" + s1 + "))[.\\s\\S]*?(?=(</span>))", RegexOptions.Multiline | RegexOptions.Singleline);
            Regex rg2 = new Regex("(?<=(" + s2 + "))[.\\s\\S]*?(?=(</span>))", RegexOptions.Multiline | RegexOptions.Singleline);
            List<Data> ls = new List<Data>();
            foreach (Match a in rg1.Matches(str))
            {
                int b = 0;
                Data aa = new Data();
                aa.Name = a.Value;
                aa.Rank = rg2.Matches(str)[b].Value;
                ls.Add(aa);
                b++;
            }
            return ls;
        }


    }

    public class Data
    {
       public string Name;
       public string Rank;
    }

}
