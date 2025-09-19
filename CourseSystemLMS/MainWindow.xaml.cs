using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseSystemLMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Load default page when app starts
            MainFrame.Navigate(new Views.DashboardPage());
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.DashboardPage());
        }

        private void Students_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.Students());
        }

        private void Groups_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.Groups());
        }

        private void Payments_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.Payments());
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.Payments());
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.Settings());
        }
    }
}