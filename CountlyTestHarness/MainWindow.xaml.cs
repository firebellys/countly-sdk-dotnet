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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CountlySDK;

namespace CountlyTestHarness
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Countly.StartSession("http://cloud.count.ly", "8920f7d88827fd961f09c8a022ea88ed642b17e5");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Countly.EndSession();
        }

        private void TestEventClick(object sender, RoutedEventArgs e)
        {
            Countly.RecordEvent("Link Click");
        }
    }
}
