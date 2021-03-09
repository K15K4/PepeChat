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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Icon = new BitmapImage(new Uri("pack://application:,,,/Resources/4.png"));
            ShowPepe1.MouseUp += new MouseButtonEventHandler(ShowPepe1_MouseUp);
            ShowPepe1.MouseDown += new MouseButtonEventHandler(ShowPepe1_MouseDown);
            ShowPepe2.MouseUp += new MouseButtonEventHandler(ShowPepe2_MouseUp);
            ShowPepe2.MouseDown += new MouseButtonEventHandler(ShowPepe2_MouseDown);
        }

        private void ShowPepe1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowPepe1.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/TripleMonkasSleep.png"));
        }

        private void ShowPepe1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowPepe1.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/TripleMonkas.png")); 
        }
        private void ShowPepe2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowPepe2.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/TripleMonkasSleep.png"));
        }

        private void ShowPepe2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowPepe2.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/TripleMonkas.png"));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow window = new LoginWindow();
            this.Hide();
            window.Show();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
