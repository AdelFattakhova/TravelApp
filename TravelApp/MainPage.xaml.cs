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

namespace TravelApp
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, RoutedEventArgs e)
        {
            ListPage listPage = new ListPage();
            NavigationService.Navigate(new Uri("listPage.xaml", UriKind.Relative));
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService.Navigate(new Uri("loginPage.xaml", UriKind.Relative));
        }

        private void buttonFind_Click(object sender, RoutedEventArgs e)
        {
            FindPage findPage = new FindPage();
            NavigationService.Navigate(new Uri("findPage.xaml", UriKind.Relative));
        }
    }
}
