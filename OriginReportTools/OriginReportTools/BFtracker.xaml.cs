using Json;
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
        public BFtracker(string PlayerName,string token)
        {
            InitializeComponent();
            Title = PlayerName+"-战绩查询工具";
            Name = PlayerName;
            DataGridOverview.AutoGenerateColumns = false;
            DataGridOverview.CanUserAddRows = true;

            DataGridClasses.AutoGenerateColumns = false;
            DataGridClasses.CanUserAddRows = true;

            DataGridWeapons.AutoGenerateColumns = false;
            DataGridWeapons.CanUserAddRows = true;

            DataGridVehicles.AutoGenerateColumns = false;
            DataGridVehicles.CanUserAddRows = true;

            ShowDataAsync();
        }

        private async void ShowDataAsync()
        {
            IJson json = JsonParser.Parse(await RequestJsonAsync(string.Format("https://api.tracker.gg/api/v1/bfv/profile/origin/{0}", Name)));

            Overview overview = new Overview(json.GetValue("data"));
            List<Overview> overviews = new List<Overview>(new Overview[] { overview });
            DataGridOverview.ItemsSource = overviews;
            PlayTime.Text = overview.PlayedTime;
            LastPlayTime.Text = overview.LastPlayed;

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(Regex.Unescape(json.GetValue("data").GetValue("account").GetValue("avatarUrl").ToString()));
            bitmapImage.DecodePixelWidth = 320;
            bitmapImage.EndInit();
            Img.Source = bitmapImage;

            List<Class> classes = new List<Class>();
            foreach (IJson i in json.GetValue("data").GetValue("classes"))
            {
                Class @class = new Class(i);
                classes.Add(@class);
            }
            DataGridClasses.ItemsSource = classes;

            List<IHasCodeName> weapons = new List<IHasCodeName>();
            foreach (IJson i in json.GetValue("data").GetValue("weapons"))
            {
                Weapon weapon = new Weapon(i);
                weapons.Add(weapon);
            }
            DataGridWeapons.ItemsSource = weapons;

            List<IHasCodeName> vehicles = new List<IHasCodeName>();
            foreach (IJson i in json.GetValue("data").GetValue("vehicles"))
            {
                Vehicle vehicle = new Vehicle(i);
                vehicles.Add(vehicle);
            }
            DataGridVehicles.ItemsSource = vehicles;

            await CodeToNameAsync(weapons);
            DataGridWeapons.Items.Refresh();

            await CodeToNameAsync(vehicles);
            DataGridVehicles.Items.Refresh();
        }

        private async Task CodeToNameAsync(List<IHasCodeName> hasNames)
        {
            IJson json = JsonParser.Parse(await RequestJsonAsync(string.Format("https://api.tracker.gg/api/v1/bfv/profile/origin/{0}/{1}", Name, hasNames[0].ID)));

            Dictionary<string, string> codeDic = new Dictionary<string, string>();
            foreach (IJson i in json.GetValue("data").GetValue("children"))
                codeDic.Add(i.GetValue("id").ToString(), i.GetValue("metadata").GetValue("name").ToString());

            foreach(IHasCodeName i in hasNames)
            {
                i.Name = codeDic[i.Code];
            }
            DataGridWeapons.Items.Refresh();
        }

        private async Task<string> RequestJsonAsync(string url)
        {
            WebRequest request = WebRequest.Create(url);
            using(WebResponse response = await request.GetResponseAsync())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8")))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private class Overview
        {
            public string Name { get; set; }
            public string LastPlayed { get; set; }
            public string PlayedTime { get; set; }
            public string ScoreMin { get; set; }
            public string KD { get; set; }
            public string Rank { get; set; }
            public string WinP { get; set; }
            public string Kill { get; set; }
            public string KPM { get; set; }
            public string Wins { get; set; }
            public string Deaths { get; set; }
            public string Assists { get; set; }
            public string Damage { get; set; }
            public string Heals { get; set; }
            public string Revives { get; set; }
            public string Resupplies { get; set; }

            public Overview(IJson json)
            {
                Name = json.GetValue("account").GetValue("playerName").ToString();
                LastPlayed = json.GetValue("stats").GetValue("lastUpdated").ToString();
                PlayedTime = json.GetValue("stats").GetValue("timePlayed").GetValue("displayValue").ToString();
                ScoreMin = json.GetValue("stats").GetValue("scorePerMinute").GetValue("displayValue").ToString();
                KD = json.GetValue("stats").GetValue("kdRatio").GetValue("displayValue").ToString();
                Rank = json.GetValue("stats").GetValue("rank").GetValue("displayValue").ToString();
                WinP = json.GetValue("stats").GetValue("wlPercentage").GetValue("displayValue").ToString();
                Kill = json.GetValue("stats").GetValue("kills").GetValue("displayValue").ToString();
                KPM = json.GetValue("stats").GetValue("killsPerMinute").GetValue("displayValue").ToString();
                Wins = json.GetValue("stats").GetValue("wins").GetValue("displayValue").ToString();
                Deaths = json.GetValue("stats").GetValue("deaths").GetValue("displayValue").ToString();
                Assists = json.GetValue("stats").GetValue("assists").GetValue("displayValue").ToString();
                Damage = json.GetValue("stats").GetValue("damage").GetValue("displayValue").ToString();
                Heals = json.GetValue("stats").GetValue("heals").GetValue("displayValue").ToString();
                Revives = json.GetValue("stats").GetValue("revives").GetValue("displayValue").ToString();
                Resupplies = json.GetValue("stats").GetValue("resupplies").GetValue("displayValue").ToString();

                PlayedTime = PlayedTime.Replace("d", "天").Replace("h", "时").Replace("m", "分");
                LastPlayed = DateTime.Parse(LastPlayed).ToLocalTime().ToString("F");
            }
        }

        private interface IHasCodeName
        {
            string ID { get; set; }
            string Code { get; set; }
            string Name { get; set; }
        }

        private class Class
        {
            public string Name { get; set; }
            public string Rank { get; set; }
            public string Score { get; set; }
            public string ScoreMin { get; set; }
            public string Kill { get; set; }
            public string KPM { get; set; }
            public string KD { get; set; }

            public Class(IJson json)
            {
                Name = json.GetValue("class").ToString();
                Rank = json.GetValue("rank").GetValue("displayValue").ToString();
                Score = json.GetValue("score").GetValue("displayValue").ToString();
                ScoreMin = json.GetValue("scorePerMinute").GetValue("displayValue").ToString();
                Kill = json.GetValue("kills").GetValue("displayValue").ToString();
                KPM = json.GetValue("killsPerMinute").GetValue("displayValue").ToString();
                KD = json.GetValue("kdRatio").GetValue("displayValue").ToString();
            }

        }

        private class Weapon : IHasCodeName
        {
            public string ID { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string Kill { get; set; }
            public string KPM { get; set; }
            public string TimePlayed { get; set; }
            public string ShotsFired { get; set; }
            public string ShotsHit { get; set; }
            public string ShotsAccuracy { get; set; }
            public string Headshots { get; set; }

            public Weapon(IJson json)
            {
                ID = "weapons";
                Code = ID + "." + json.GetValue("code").ToString();
                Name = json.GetValue("code").ToString();
                Kill = json.GetValue("kills").GetValue("displayValue").ToString();
                KPM = json.GetValue("killsPerMinute").GetValue("displayValue").ToString();
                TimePlayed = json.GetValue("timePlayed").GetValue("displayValue").ToString();
                ShotsFired = json.GetValue("shotsFired").GetValue("displayValue").ToString();
                ShotsHit = json.GetValue("shotsHit").GetValue("displayValue").ToString();
                ShotsAccuracy = json.GetValue("ShotsAccuracy").GetValue("displayValue").ToString();
                Headshots = json.GetValue("headshots").GetValue("displayValue").ToString();

                TimePlayed = TimePlayed.Replace("h", "时").Replace("m", "分").Replace("s", "秒").Replace("d", "天");
            }

        }

        private class Vehicle : IHasCodeName
        {
            public string ID { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string Kill { get; set; }
            public string KPM { get; set; }
            public string TimePlayed { get; set; }
            public string Destroyed { get; set; }

            public Vehicle(IJson json)
            {
                ID = "vehicles";
                Code = ID + "." + json.GetValue("code").ToString();
                Name = json.GetValue("code").ToString();
                Kill = json.GetValue("kills").GetValue("displayValue").ToString();
                KPM = json.GetValue("killsPerMinute").GetValue("displayValue").ToString();
                TimePlayed = json.GetValue("timePlayed").GetValue("displayValue").ToString();
                Destroyed = json.GetValue("destroyed").GetValue("displayValue").ToString();

                TimePlayed = TimePlayed.Replace("h", "时").Replace("m", "分").Replace("s", "秒").Replace("d", "天");
            }

        }

        private void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (!e.Handled)
            {
                e.Handled = true;
                var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
                eventArg.RoutedEvent = MouseWheelEvent;
                eventArg.Source = sender;
                var parent = (UIElement)((Control)sender).Parent;
                parent.RaiseEvent(eventArg);
            }
        }
    }
}
