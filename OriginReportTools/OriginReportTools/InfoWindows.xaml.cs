using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// InfoWindows.xaml 的交互逻辑
    /// </summary>
    public partial class InfoWindows : Window
    {
        public InfoWindows(string Link)
        {
            InitializeComponent();
            InfoBroswer.Navigate(Link);
            this.ShowInTaskbar = false;
            this.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            InfoBroswer.Dispose();
            this.Close();

        }
    }
}
