using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace TravelApp
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private string CalculateHash(string password)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            return Convert.ToBase64String(hash);
        }

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text == "fattakhova" && passwordBox.Password == "1234321")
                NavigationService.Navigate(new Uri("AddPage.xaml", UriKind.Relative));
            else
                MessageBox.Show("Неверный пароль", "Ошибка!",MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
