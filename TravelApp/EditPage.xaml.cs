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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
            dateGoPicker.DisplayDateStart = DateTime.Today;
            dateBackPicker.DisplayDateStart = DateTime.Today;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if ((cityFromBox.Text == null) || (cityToBox.Text == null) || (countryBox.Text == null) || (hotelBox.Text == null) || (priceBox.Text == null) ||
                (dateGoPicker.SelectedDate == null) || (dateBackPicker.SelectedDate == null) || (roomPrice1Box.Text == null) || (roomPrice2Box.Text == null) || (roomPrice3Box.Text == null))
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

            Pages.ListPage.selectedHotel = new Hotels(hotelBox.Text, Convert.ToDouble(roomPrice1Box.Text), Convert.ToDouble(roomPrice2Box.Text),
                    Convert.ToDouble(roomPrice3Box.Text));
            Pages.ListPage.selectedCityTo = new CityTo(cityToBox.Text, countryBox.Text, Pages.ListPage.selectedHotel);
            Pages.ListPage.selectedTour = new Tours(cityFromBox.Text, Pages.ListPage.selectedCityTo, Convert.ToInt32(priceBox.Text),
                    Pages.AddPage.ConvertDate(Convert.ToDateTime(dateGoPicker.SelectedDate)), Pages.AddPage.ConvertDate(Convert.ToDateTime(dateBackPicker.SelectedDate)));
            Pages.AddPage._tours.Remove(Pages.AddPage._tours[Pages.ListPage.listViewTours.SelectedIndex]);
            Pages.AddPage._tours.Add(Pages.ListPage.selectedTour);
            Pages.ListPage.RefreshListView();
            Pages.ToursPage.RefreshListView();
            Pages.ListPage.SerializeData();
            NavigationService.GoBack();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            cityFromBox.Text = null; countryBox.Text = null; cityToBox.Text = null;
            priceBox.Text = null; hotelBox.Text = null; roomPrice1Box.Text = null;
            roomPrice2Box.Text = null; roomPrice3Box.Text = null;
            dateGoPicker.SelectedDate = null; dateBackPicker.SelectedDate = null;
        }
    }
}
