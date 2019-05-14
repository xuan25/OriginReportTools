﻿using Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
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

namespace OriginReportTools
{
    /// <summary>
    /// UpdatePrompt.xaml 的交互逻辑
    /// </summary>
    public partial class UpdatePrompt : UserControl
    {
        /// <summary>
        /// NewVersionFound delegate.
        /// </summary>
        public delegate void NewVersionFoundDel();
        /// <summary>
        /// Occurs when a new version has been recieved.
        /// </summary>
        public event NewVersionFoundDel NewVersionFound;

        /// <summary>
        /// Confirmed delegate.
        /// </summary>
        /// <param name="IsUpdate">Is update</param>
        public delegate void ConfirmedDel(bool IsUpdate);
        /// <summary>
        /// Occurs when user comfirmd a sellection.
        /// </summary>
        public event ConfirmedDel Confirmed;

        public string UpdaterPath;
        public FileStream CheckingFileStream;
        public Thread CheckVersionThread;

        public UpdatePrompt()
        {
            InitializeComponent();
            UpdaterPath = AppDomain.CurrentDomain.BaseDirectory + "OriginRepTools-updater.exe";
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            StartCheckVersion();
        }

        public void StopCheckVersion()
        {
            if (CheckVersionThread != null)
                CheckVersionThread.Abort();
            if (CheckingFileStream != null)
                CheckingFileStream.Close();
        }

        public void StartCheckVersion()
        {
            CheckVersionThread = new Thread(delegate ()
            {
                if (File.Exists(UpdaterPath))
                {
                    while (IsFileInUse(UpdaterPath))
                    {
                        Thread.Sleep(1000);
                    }
                    File.Delete(UpdaterPath);
                }
                if (!IsLatestVersion())
                {
                    NewVersionFound?.Invoke();
                    Dispatcher.Invoke(new Action(() =>
                    {
                        this.Visibility = Visibility.Visible;
                    }));
                }
            });
            CheckVersionThread.Start();
        }

        public bool IsFileInUse(string fileName)
        {
            bool inUse = true;
            try
            {
                CheckingFileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                inUse = false;
            }
            catch
            {

            }
            finally
            {
                if (CheckingFileStream != null)
                    CheckingFileStream.Close();
            }
            return inUse;
        }

        public bool IsLatestVersion()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.github.com/repos/xuan525/Bili-dl/releases/latest");
            request.Accept = "application/vnd.github.v3+json";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.103 Safari/537.36";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string result = reader.ReadToEnd();
                reader.Close();
                response.Close();
                dataStream.Close();

                IJson json = JsonParser.Parse(result);
                string latestTag = json.GetValue("tag_name").ToString();
                return Application.Current.FindResource("Version").ToString() == latestTag;
            }
            catch
            {
                return true;
            }
        }

        private void LaterBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Confirmed?.Invoke(false);
        }

        private void NowBtn_Click(object sender, RoutedEventArgs e)
        {
            ExportResource(UpdaterPath, "Updater.Bili-dl-updater.exe");
            System.Diagnostics.Process.Start(UpdaterPath, System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Confirmed?.Invoke(true);
        }

        private void ExportResource(string path, string source)
        {
            string projectName = Assembly.GetExecutingAssembly().GetName().Name.ToString().Replace("-", "_");
            Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(projectName + "." + source);
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            resourceStream.CopyTo(fileStream);
            fileStream.Close();
            resourceStream.Close();
        }
    }
}
