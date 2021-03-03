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

namespace SuppaChat
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Icon = new BitmapImage(new Uri("pack://application:,,,/Resources/4.png"));
            ShowPepe.MouseUp += new MouseButtonEventHandler(ShowPepe_MouseUp);
            ShowPepe.MouseDown += new MouseButtonEventHandler(ShowPepe_MouseDown);
        }

        private void ShowPepe_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowPepe.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/TripleMonkas.png"));
        }

        private void ShowPepe_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowPepe.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/TripleMonkasSleep.png"));
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow window = new RegistrationWindow();
            this.Hide();
            window.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
