using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows;

namespace OriginReportTools
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Resources.Add("Version", "v0.7.0-alpha");

            GamesDataSetDemo Data = new GamesDataSetDemo();
            SerializableSave(Data.Data);

        }

        public void SerializableSave(GamesDataSet chEnData)
        {
            string fileDirectory = Environment.CurrentDirectory + "\\";
            if (!Directory.Exists(fileDirectory))
                Directory.CreateDirectory(fileDirectory);
            string fileName = "ChEnData.dat";
            Stream stream = new FileStream(fileDirectory + fileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, chEnData);
            stream.Close();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (e.Args.Length == 0)
            {
                new MainWindow().Show();
            }
            else
            {
                switch (e.Args[0].ToLower())
                {
                    case "-update":
                        UpdatePrompt.RunUpdate();
                        Environment.Exit(0);
                        break;
                    default:
                        MessageBox.Show("Invalid arguments");
                        Environment.Exit(0);
                        break;
                }
            }
        }


    }
}
