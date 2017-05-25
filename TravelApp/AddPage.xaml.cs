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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public List<Tours> _tours = new List<Tours>();
        public List<CityTo> _citiesTo = new List<CityTo>();
        public List<Hotels> _hotels = new List<Hotels>();

        public AddPage()
        {
            InitializeComponent();
            dateGoPicker.DisplayDateStart = DateTime.Today;
            dateBackPicker.DisplayDateStart = DateTime.Today;
        }

        Hotels _newHotel;

        public Hotels NewHotel
        {
            get { return _newHotel; }
        }

        CityTo _newCityTo;

        public CityTo NewCityTo
        {
            get { return _newCityTo; }
        }

        Tours _newTour;

        public Tours NewTour
        {
            get { return _newTour; }
        }

        public string ConvertDate(DateTime date)
        {
            return date.ToString("dd.MM.yyyy");
        }

        bool _cityFromEntered = false;
        private void cityFromBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_cityFromEntered) || (cityFromBox.Text == "Город отправления"))
            {
                cityFromBox.Text = "";
                cityFromBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void cityFromBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityFromBox.Text))
                _cityFromEntered = true;
            else
            {
                cityFromBox.Text = "Город отправления";
                _cityFromEntered = false;
                cityFromBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _countryEntered = false;
        private void countryBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_countryEntered) || (countryBox.Text == "Страна прибытия"))
            {
                countryBox.Text = "";
                countryBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void countryBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(countryBox.Text))
                _countryEntered = true;
            else
            {
                countryBox.Text = "Страна прибытия";
                _countryEntered = false;
                countryBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _cityToEntered = false;
        private void cityToBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_cityToEntered) || (cityToBox.Text == "Город прибытия"))
            {
                cityToBox.Text = "";
                cityToBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void cityToBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityToBox.Text))
                _cityToEntered = true;
            else
            {
                cityToBox.Text = "Город прибытия";
                _cityToEntered = false;
                cityToBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _priceEntered = false;
        private void priceBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_priceEntered) || (priceBox.Text == "Цена"))
            {
                priceBox.Text = "";
                priceBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void priceBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(priceBox.Text))
                _priceEntered = true;
            else
            {
                priceBox.Text = "Цена";
                _priceEntered = false;
                priceBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _hotelEntered = false;
        private void hotelBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_hotelEntered) || (hotelBox.Text == "Название отеля"))
            {
                hotelBox.Text = "";
                hotelBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void hotelBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(hotelBox.Text))
                _hotelEntered = true;
            else
            {
                hotelBox.Text = "Название отеля";
                _hotelEntered = false;
                hotelBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _roomPrice1Entered = false;
        private void roomPrice1Box_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_roomPrice1Entered) || (roomPrice1Box.Text == "Цена 1-местного номера"))
            {
                roomPrice1Box.Text = "";
                roomPrice1Box.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void roomPrice1Box_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(roomPrice1Box.Text))
                _roomPrice1Entered = true;
            else
            {
                roomPrice1Box.Text = "Цена 1-местного номера";
                _roomPrice1Entered = false;
                roomPrice1Box.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _roomPrice2Entered = false;
        private void roomPrice2Box_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_roomPrice2Entered) || (roomPrice2Box.Text == "Цена 2-местного номера"))
            {
                roomPrice2Box.Text = "";
                roomPrice2Box.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void roomPrice2Box_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(roomPrice2Box.Text))
                _roomPrice2Entered = true;
            else
            {
                roomPrice2Box.Text = "Цена 2-местного номера";
                _roomPrice2Entered = false;
                roomPrice2Box.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _roomPrice3Entered = false;
        private void roomPrice3Box_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((!_roomPrice3Entered) || (roomPrice3Box.Text == "Цена 3-местного номера"))
            {
                roomPrice3Box.Text = "";
                roomPrice3Box.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void roomPrice3Box_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(roomPrice3Box.Text))
                _roomPrice3Entered = true;
            else
            {
                roomPrice3Box.Text = "Цена 3-местного номера";
                _roomPrice3Entered = false;
                roomPrice3Box.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        public void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((cityFromBox.Text == "Город отправления") || (cityToBox.Text == "Город прибытия") || (countryBox.Text == "Страна прибытия") || (hotelBox.Text == "Название отеля") || (priceBox.Text == "Цена") ||
                (dateGoPicker.SelectedDate == null) || (dateBackPicker.SelectedDate == null) || (roomPrice1Box.Text == "Цена 1-местного номера") || (roomPrice2Box.Text == "Цена 2-местного номера") || (roomPrice3Box.Text == "Цена 3-местного номера"))
            {
                MessageBox.Show("Введены не все данные!", "Ошибка");
                return;
            }
            int a, b, c, d;
            double f, g, h, i, j, k, l, m;
            if ((int.TryParse(cityFromBox.Text, out a) == true) && (double.TryParse(cityFromBox.Text, out f) == true))
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка");
                cityFromBox.Focus();
                return;
            }

            if ((int.TryParse(cityToBox.Text, out b) == true) && (double.TryParse(cityToBox.Text, out g) == true))
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка");
                cityToBox.Focus();
                return;
            }

            if ((int.TryParse(countryBox.Text, out c) == true) && (double.TryParse(countryBox.Text, out h) == true))
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка");
                countryBox.Focus();
                return;
            }

            if ((int.TryParse(hotelBox.Text, out d) == true) && (double.TryParse(hotelBox.Text, out i) == true))
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка");
                cityFromBox.Focus();
                return;
            }

            if (double.TryParse(priceBox.Text, out j) == false)
            {
                MessageBox.Show("Неверный формат данных! Если число дробное, оно должно быть введено через запятую.", "Ошибка");
                priceBox.Focus();
                return;
            }

            if (double.TryParse(roomPrice1Box.Text, out k) == false)
            {
                MessageBox.Show("Неверный формат данных! Если число дробное, оно должно быть введено через запятую.", "Ошибка");
                roomPrice1Box.Focus();
                return;
            }

            if (double.TryParse(roomPrice2Box.Text, out l) == false)
            {
                MessageBox.Show("Неверный формат данных! Если число дробное, оно должно быть введено через запятую.", "Ошибка");
                roomPrice2Box.Focus();
                return;
            }

            if (double.TryParse(roomPrice3Box.Text, out m) == false)
            {
                MessageBox.Show("Неверный формат данных! Если число дробное, оно должно быть введено через запятую.", "Ошибка");
                roomPrice3Box.Focus();
                return;
            }

            _newHotel = new Hotels(hotelBox.Text, Convert.ToDouble(roomPrice1Box.Text), Convert.ToDouble(roomPrice2Box.Text),
                    Convert.ToDouble(roomPrice3Box.Text));
            _newCityTo = new CityTo(cityToBox.Text, countryBox.Text, _newHotel);
            _newTour = new Tours(cityFromBox.Text, _newCityTo, Convert.ToInt32(priceBox.Text),
                    ConvertDate(Convert.ToDateTime(dateGoPicker.SelectedDate)), ConvertDate(Convert.ToDateTime(dateBackPicker.SelectedDate)));

            MessageBoxResult result = MessageBox.Show("Добавить новый тур?", "Подтвердите действие", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                _hotels.Add(_newHotel);
                _citiesTo.Add(_newCityTo);
                _tours.Add(_newTour);
                NavigationService.Navigate(Pages.ListPage);
                Pages.ListPage.RefreshListView();
                Pages.ToursPage.RefreshListView();
                Pages.ListPage.SerializeData();
                cityFromBox.Text = "Город отправления"; cityFromBox.Foreground = new SolidColorBrush(Colors.Gray); cityToBox.Text = "Город прибытия"; cityToBox.Foreground = new SolidColorBrush(Colors.Gray);
                countryBox.Text = "Страна прибытия"; countryBox.Foreground = new SolidColorBrush(Colors.Gray); priceBox.Text = "Цена"; priceBox.Foreground = new SolidColorBrush(Colors.Gray);
                dateGoPicker.SelectedDate = null; dateBackPicker.SelectedDate = null; hotelBox.Text = "Название отеля"; hotelBox.Foreground = new SolidColorBrush(Colors.Gray);
                roomPrice1Box.Text = "Цена 1-местного номера"; roomPrice1Box.Foreground = new SolidColorBrush(Colors.Gray);
                roomPrice2Box.Text = "Цена 2-местного номера"; roomPrice2Box.Foreground = new SolidColorBrush(Colors.Gray);
                roomPrice3Box.Text = "Цена 3-местного номера"; roomPrice3Box.Foreground = new SolidColorBrush(Colors.Gray);
            }
            if (result == MessageBoxResult.No)
                NavigationService.Navigate(Pages.AddPage);
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.ListPage);
            cityFromBox.Text = "Город отправления"; cityFromBox.Foreground = new SolidColorBrush(Colors.Gray); cityToBox.Text = "Город прибытия"; cityToBox.Foreground = new SolidColorBrush(Colors.Gray);
            countryBox.Text = "Страна прибытия"; countryBox.Foreground = new SolidColorBrush(Colors.Gray); priceBox.Text = "Цена"; priceBox.Foreground = new SolidColorBrush(Colors.Gray);
            dateGoPicker.SelectedDate = null; dateBackPicker.SelectedDate = null; hotelBox.Text = "Название отеля"; hotelBox.Foreground = new SolidColorBrush(Colors.Gray);
            roomPrice1Box.Text = "Цена 1-местного"; roomPrice1Box.Foreground = new SolidColorBrush(Colors.Gray);
            roomPrice2Box.Text = "Цена 2-местного"; roomPrice2Box.Foreground = new SolidColorBrush(Colors.Gray);
            roomPrice3Box.Text = "Цена 3-местного"; roomPrice3Box.Foreground = new SolidColorBrush(Colors.Gray);
        }
    }
}
