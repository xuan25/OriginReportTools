using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace OriginReportTools
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginWindows loginWindows;

        EAHttp eahttp = new EAHttp();
        /// <summary>
        /// 反序列化ChEnData.dat文件后的内容存储在此处
        /// </summary>
        GamesDataSet CHENDATA;
        /// <summary>
        /// 储存当前界面选择的游戏
        /// </summary>
        public string GameName;

        public List<HackData> HackDataList=new List<HackData>();
        /// <summary>
        /// 作弊选项
        /// </summary>
        List<string> CheckTypesList=new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            LoadChEnData();
            HackDateListLoad();

            //MainButton = chendata.BF1;
            //chendata.SerializableSave(chendata);
            LoadCheckBox(CHENDATA.Games["战地1"]);
            GameName = "战地1";
            loginWindows = new LoginWindows();
            loginWindows.LoggedIn += LoginWindow_LoggedIn;
            loginWindows.LoggedOut += LoginWindow_LoggedOut;
            loginWindows.LoginCanceled += LoginWindow_LoginCanceled;
            loginWindows.Loggeding1 += LoginWindow_Loggeding1;
            loginWindows.Loggeding2 += LoginWindow_Loggeding2;
            
        }
        /// <summary>
        /// 反序列化翻译数据文件
        /// </summary>
        /// <returns>返回序列化的成功与否</returns>
        private bool LoadChEnData()
        {
            string path = Environment.CurrentDirectory + "\\ChEnData.dat";
            if (!File.Exists(path))
            {
                return false;
            }
            try
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                CHENDATA = (GamesDataSet)binaryFormatter.Deserialize(stream);
                stream.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void LoginWindow_LoggedIn(string token)
        {
            
            Dispatcher.Invoke(new Action(() =>
            {
                LoginText.Text = "登陆成功";
                try
                {
                    string[] A = token.Split('"');
                    eahttp.Token = A[3];
                    LoginText.Text = "注销";
                    eahttp.GetMe();
                    PlayerName.Text = eahttp.PlayerName;
                    Email.Text = eahttp.Email;
                    IMG.Source = eahttp.bitmapImage;
                }
                catch
                {
                    LoginText.Text = "登陆";
                    loginWindows.Logout();
                    PlayerName.Text = "登陆失败";
                    IMG.Source = null;
                }

            }));
        }
        private void LoginWindow_Loggeding1()
        {
            Dispatcher.Invoke(new Action(() =>
            {
                PlayerName.Text = "检测到已登陆过...正在跳转";

            }));
        }
        private void LoginWindow_Loggeding2()
        {
            Dispatcher.Invoke(new Action(() =>
            {
                PlayerName.Text = "未检测到登陆用户...";

            }));
        }

        private void LoginWindow_LoggedOut()
        {
            Dispatcher.Invoke(new Action(() =>
            {
                LoginText.Text = "Logged out";
                PlayerName.Text = "登陆操操作已被取消";
            }));
        }

        private void LoginWindow_LoginCanceled()
        {
            Dispatcher.Invoke(new Action(() =>
            {
                LoginText.Text = "重新登陆";
            }));
        }
        /// <summary>
        /// 登陆按钮被点击时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginText.Text == "登陆"| LoginText.Text == "重新登陆")
            {
                LoginText.Text = "载入中";
                PlayerName.Text = "请耐心等待";
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
        /// <summary>
        /// 主窗口关闭时触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loginWindows.Close();

        }
        /// <summary>
        /// BF1按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BF1_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(4f, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(0, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(0, 0, 0, 0);
            LoadCheckBox(CHENDATA.Games["战地1"]);
            GameName = "战地1";
            CheckTypesList.Clear();

        }
        /// <summary>
        /// 战地V按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BFV_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(0, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(4f, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(0, 0, 0, 0);
            LoadCheckBox(CHENDATA.Games["战地V"]);
            GameName = "战地V";
            CheckTypesList.Clear();

        }
        /// <summary>
        /// APEX按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void APEX_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(0, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(0, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(4f, 0, 0, 0);
            LoadCheckBox(CHENDATA.Games["APEX"]);
            CheckTypesList.Clear();
        }
        /// <summary>
        /// 动态的从反序列化后的数据中载入游戏对应的作弊选项框
        /// </summary>
        /// <param name="Name">游戏的名字</param>

        private void LoadCheckBox(GamesDataSet.Game Name)
        {
            CheckList.Children.Clear();
            foreach (KeyValuePair<string, GamesDataSet.Game.CheckType> check in Name.CheckTypes)
            {
                CheckBox cb = new CheckBox();
                cb.Content = check.Key;
                cb.Tag = check.Value;
                cb.Margin = new Thickness(0,0,10f,0);
                cb.AddHandler(CheckBox.CheckedEvent, new RoutedEventHandler(Checked));
                cb.AddHandler(CheckBox.UncheckedEvent, new RoutedEventHandler(Unchecked));
                CheckList.Children.Add(cb);

            }

            GameClass.Items.Clear();
            GameMap.Items.Clear();

            foreach (KeyValuePair<string, GamesDataSet.Game.Arm> arm in Name.Arms)
            {
                GameClass.Items.Add(arm.Key);
            }


            foreach (KeyValuePair<string, GamesDataSet.Game.Map> map in Name.Maps)
            {
                GameMap.Items.Add(map.Key);
            }
        }
        /// <summary>
        /// 生成的作弊选项框被选中时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checked(object sender, RoutedEventArgs e)
        {

            CheckTypesList.Add(((CheckBox)sender).Content.ToString());

       }
        /// <summary>
        /// 生成的作弊选项框被取消选中时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Unchecked(object sender, RoutedEventArgs e)
        {
            CheckTypesList.Remove(((CheckBox)sender).Content.ToString());
           
        }




        /// <summary>
        /// 兵种列表下拉选项关闭时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameClass_DropDownClosed(object sender, EventArgs e)
        {
            //foreach(MainButton.Class.)
        }




        /// <summary>
        /// 武器种类列表下拉选项打开时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeaponClass_DropDownOpened(object sender, EventArgs e)
        {
            WeaponClass.Items.Clear();
            foreach (KeyValuePair<string, GamesDataSet.Game.Arm.EquipmentSet>  WPC in CHENDATA.Games[GameName].Arms[GameClass.Text].EquipmentSets)
            {
               WeaponClass.Items.Add(WPC.Key);
            }
        }



        /// <summary>
        /// 武器列表下拉选中打开时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeaponList_DropDownOpened(object sender, EventArgs e)
        {
            WeaponList.Items.Clear();
            foreach (KeyValuePair<string, GamesDataSet.Game.Arm.EquipmentSet.Equipment> WPL in CHENDATA.Games[GameName].Arms[GameClass.Text].EquipmentSets[WeaponClass.Text].Equipments)
            {
                WeaponList.Items.Add(WPL.Key);
            }
        }

        /// <summary>
        /// 举报至EA按钮被点击时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Report_But_Click(object sender, RoutedEventArgs e)
        {
            //if (!eahttp.NameGetID(HackName.Text))
            //{
            //    MessageBox.Show("该玩家不存在");
            //    return;
            //}
            HackData Hdata = new HackData();
            Hdata.Key = HackDataList.Count+1;
            Hdata.HackName = HackName.Text;
            Hdata.HackEAID = eahttp.HackerEAID;
            Hdata.HackCheckType = CheckTypesList;
            Hdata.Game = GameName;
            Hdata.Class = GameClass.Text;
            Hdata.Map = GameMap.Text;
            Hdata.K = K.Text;
            Hdata.D = D.Text;
            Hdata.PlayerName = eahttp.PlayerName;
            Hdata.PlayerEAID = eahttp.PlayerEAID;
            Hdata.ReportTime = eahttp.GetNetDateTime();
            HackDataList.Add(Hdata);
            HackDateListSave(HackDataList);

        }

        public void IDCheck()
        {
            bool a = eahttp.NameGetID(HackName.Text);
            if (a == true & eahttp.HackerEAID != "failure")
            {
                A.Text = "该玩家存在";
                A.Foreground = Brushes.Green;
            }
            else if (a == true & eahttp.HackerEAID == "failure")
            {
                A.Text = "未登陆，无法验证玩家是否存在";
                A.Foreground = Brushes.Gray;
            }
            else if (a == false & eahttp.HackerEAID == null)
            {
                A.Text = "该玩家不存在";
                A.Foreground = Brushes.Red;
            }
        }

        private void HackName_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                IDCheck();
            }
            if (e.Key == System.Windows.Input.Key.Tab)
            {
                try
                {

                    HackName.Text = eahttp.IDGetName(HackName.Text);
                }
                catch
                {

                }
               
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataBinding();
        }

        public void dataBinding()
        {
            List<object> aList = new List<object>();
            HackData ps1 = new HackData();//单行数据
            ps1.Key = 111;
            ps1.Class = "20180907";
            ps1.ReportTime = new DateTime(2019, 5, 5, 0, 4, 30);
            aList.Add(ps1);

            ps1.Key = 131;
            ps1.Class = "20180906";
            ps1.ReportTime = new DateTime(2019, 5, 6, 0, 4, 30);
            aList.Add(ps1);
            DataGrid.ItemsSource = aList;
            DataGrid.AutoGenerateColumns = false;//禁止自动添加列
            DataGrid.CanUserAddRows = false;//禁止自动添加行
            PlayerName.Text = ps1.ReportTime.ToLocalTime().ToString();
            DateTime c =  DateTime.Parse(PlayerName.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextProcessing a = new TextProcessing();
            string c = a.ToString(CheckTypesList);
            List<string> aa = a.ToList(c);
        }
        [Serializable]
        class Status
        {
            public string PlayerId, PlayerName, Email;
            public bool IsLoggedIn;
        }
        public void SaveStatus()
        {
            Status status = new Status()
            {
                //PlayerId = PlayerIdBox.Text,
                //FirstName = FirstNameBox.Text,
                //Email = EmailBox.Text,
                //Details = DetailsBox.Text,
                //IsWallHack = WallHackCkb.IsChecked == true,
                //IsAimbot = AimbotCkb.IsChecked == true,
                //IsSpeedHacked = SpeedHackedCkb.IsChecked == true,
                //IsDamageHacked = DamageHackedCkb.IsChecked == true,
                //IsSaveImg = SaveImgCkb.IsChecked == true,
                //IsLoggedIn = ea != null
            };

            string fileDirectory = Environment.CurrentDirectory + "\\";
            if (!Directory.Exists(fileDirectory))
                Directory.CreateDirectory(fileDirectory);
            string fileName = "Config.dat";
            Stream stream = new FileStream(fileDirectory + fileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, status);
            stream.Close();
        }

        public bool LoadStatus()
        {
            string path = Environment.CurrentDirectory + "\\Config.dat";
            if (!File.Exists(path))
            {
                return false;
            }
            try
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Status status = (Status)binaryFormatter.Deserialize(stream);
                stream.Close();

                //PlayerIdBox.Text = status.PlayerId;
                //FirstNameBox.Text = status.FirstName;
                //EmailBox.Text = status.Email;
                //DetailsBox.Text = status.Details;
                //WallHackCkb.IsChecked = status.IsWallHack;
                //AimbotCkb.IsChecked = status.IsAimbot;
                //SpeedHackedCkb.IsChecked = status.IsSpeedHacked;
                //DamageHackedCkb.IsChecked = status.IsDamageHacked;
                //SaveImgCkb.IsChecked = status.IsSaveImg;

                if (status.IsLoggedIn)
                    LoginBtn_Click(null, null);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void HackDateListSave(List<HackData> hackDatasList)
        {
            string fileDirectory = Environment.CurrentDirectory + "\\";
            if (!Directory.Exists(fileDirectory))
                Directory.CreateDirectory(fileDirectory);
            string fileName = "HackData.dat";
            Stream stream = new FileStream(fileDirectory + fileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream,hackDatasList);
            stream.Close();
        }
        public bool HackDateListLoad()
        {
            string path = Environment.CurrentDirectory + "\\HackData.dat";
            if (!File.Exists(path))
            {
                return false;
            }
            try
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                HackDataList = (List<HackData>)binaryFormatter.Deserialize(stream);
                stream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            loginWindows.OpenEAIDLink(eahttp.IDgetLink("GenesisAN"));
            loginWindows.Show();

            loginWindows.WindowState = WindowState.Normal;
            loginWindows.ShowInTaskbar = true;
        }
    }


}
