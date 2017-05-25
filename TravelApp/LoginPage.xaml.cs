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

        bool _loginEntered = false;
        private void loginBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_loginEntered) || (loginBox.Text == "Логин"))
            {
                loginBox.Text = "";
                loginBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void loginBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginBox.Text))
                _loginEntered = true;
            else
            {
                loginBox.Text = "Логин";
                _loginEntered = false;
                loginBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _passwordEntered = false;
        private void passwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_passwordEntered) || (passwordBox.Text == "Пароль"))
            {
                passwordBox.Text = "";
                passwordBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(passwordBox.Text))
                _passwordEntered = true;
            else
            {
                passwordBox.Text = "Пароль";
                _passwordEntered = false;
                passwordBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private string CalculateHash(string password)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            return Convert.ToBase64String(hash);
        }

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            //var hash = CalculateHash("1234321");
            //if (loginBox.Text == "fattakhova" && CalculateHash(passwordBox.Text) == hash)
            //{
            Pages.ListPage.DeserializeData();
            NavigationService.Navigate(Pages.ListPage);
            //    ListPage listPage = new ListPage();

            //}
            //else
            //    MessageBox.Show("Неверный пароль", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            //loginBox.Text = "Логин";
            //loginBox.Foreground = new SolidColorBrush(Colors.Gray);
            //passwordBox.Text = "Пароль";
            //passwordBox.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void Page_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                buttonEnter_Click(null, null);
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.MainPage);
            loginBox.Text = "Логин";
            loginBox.Foreground = new SolidColorBrush(Colors.Gray);
            passwordBox.Text = "Пароль";
            passwordBox.Foreground = new SolidColorBrush(Colors.Gray);
        }
    }
}
