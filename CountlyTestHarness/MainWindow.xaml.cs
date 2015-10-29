using System.Windows;
using System.Windows.Media;
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

        private void Start_Session_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ApiKeyBox.Text == "" || ApiKeyBox.Text == "Enter API Key")
            {
                MessageBox.Show("Please enter an API Key.");
            }
            else
            {
                Countly.StartSession("http://cloud.count.ly", ApiKeyBox.Text);
            }
        }

        private void End_Session_Button_Click(object sender, RoutedEventArgs e)
        {
            Countly.EndSession();
        }

        private void Fire_Event_Button_Click(object sender, RoutedEventArgs e)
        {
            if (EventTextBox.Text == "Enter test event name." || EventTextBox.Text == "")
            {
                MessageBox.Show("Please enter an event name for testing.");
            }
            else
            {
                Countly.RecordEvent(EventTextBox.Text);
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EventTextBox.Text == "Enter test event name.")
            {
                EventTextBox.Text = "";
                EventTextBox.Foreground = Brushes.Black;
            }
        }

        private void EventTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (EventTextBox.Text == "")
            {
                EventTextBox.Text = "Enter test event name.";
            }
        }

        private void ApiKeyBox_Focus(object sender, RoutedEventArgs e)
        {
            if (ApiKeyBox.Text == "Enter API Key")
            {
                ApiKeyBox.Text = "";
            }
        }

        private void ApiKeyBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ApiKeyBox.Text == "")
            {
                ApiKeyBox.Text = "Enter API Key";
            }
        }
    }
}
