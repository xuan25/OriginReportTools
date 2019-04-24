using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace OriginReportTools
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginWindows loginWindows;
        EAHttp eahttp = new EAHttp();
        ChEnData chendata = new ChEnData();
        Game MainButton;
        public MainWindow()
        {
            InitializeComponent();


            //LoadStatus();



            MainButton = chendata.BF1;
            chendata.SerializableSave(chendata);
            LoadCheckBox(MainButton);
            loginWindows = new LoginWindows();
            loginWindows.LoggedIn += LoginWindow_LoggedIn;
            loginWindows.LoggedOut += LoginWindow_LoggedOut;
            loginWindows.LoginCanceled += LoginWindow_LoginCanceled;
            loginWindows.Loggeding1 += LoginWindow_Loggeding1;
            loginWindows.Loggeding2 += LoginWindow_Loggeding2;
            
        }


        private void LoginWindow_LoggedIn(string token)
        {
            
            Dispatcher.Invoke(new Action(() =>
            {
                LoginText.Text = "登陆成功";
                string[]A = token.Split('"');
                eahttp.Token = A[3];
                LoginText.Text = "注销";
                eahttp.GetMe();
                PlayerName.Text = eahttp.PlayerName;
                Email.Text = eahttp.Email;
                IMG.Source = eahttp.bitmapImage;

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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loginWindows.Close();
        }

        private void BF1_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(4f, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(0, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(0, 0, 0, 0);
            MainButton = chendata.BF1;
            LoadCheckBox(MainButton);

        }

        private void BFV_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(0, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(4f, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(0, 0, 0, 0);
            MainButton = chendata.BFV;
            LoadCheckBox(MainButton);
        }

        private void APEX_B_Click(object sender, RoutedEventArgs e)
        {
            BF1_B.BorderThickness = new Thickness(0, 0, 0, 0);
            BFV_B.BorderThickness = new Thickness(0, 0, 0, 0);
            APEX_B.BorderThickness = new Thickness(4f, 0, 0, 0);
            MainButton = chendata.APEX;
            LoadCheckBox(MainButton);
        }


        private void LoadCheckBox(Game Name)
        {
            CheckList.Children.Clear();
            foreach (EnCh ench in Name.CheatCheckBox)
            {
                CheckBox cb = new CheckBox();
                cb.Content = ench.Ch;
                cb.Tag = ench.En;
                cb.AddHandler(CheckBox.CheckedEvent, new RoutedEventHandler(Checked));
                cb.AddHandler(CheckBox.UncheckedEvent, new RoutedEventHandler(Unchecked));
                CheckList.Children.Add(cb);

            }

            GameClass.Items.Clear();
            GameMap.Items.Clear();
            foreach (GameClass gc in Name.Class)
            {
                GameClass.Items.Add (gc.Name.Ch);

            }
            foreach (EnCh gc in Name.Map)
            {
                GameMap.Items.Add(gc.Ch);
            }
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            A.Text = A.Text + ((CheckBox)sender).Tag.ToString();

        }

        private void Unchecked(object sender, RoutedEventArgs e)
        {
            A.Text = A.Text.Replace(((CheckBox)sender).Tag.ToString(), "");
           
        }


        public bool LoadStatus()
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
                ChEnData chendataa = (ChEnData)binaryFormatter.Deserialize(stream);
                stream.Close();
                chendata = chendataa;

                //if (ChEnData.IsLoggedIn)
                //    LoginBtn_Click(null, null);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void GameClass_DropDownClosed(object sender, EventArgs e)
        {
            //foreach(MainButton.Class.)
        }
    }
}
