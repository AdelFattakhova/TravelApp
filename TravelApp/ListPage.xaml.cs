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
using System.IO;
using System.Xml.Serialization;

namespace TravelApp
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public class Data
    {
        private List<Tours> tours;

        public List<Tours> Tours
        {
            get { return tours; }
            set { tours = value; }
        }
    }

    public partial class ListPage : Page
    {
        const string fileName = "tours.xml";
        public ListPage()
        {
            InitializeComponent();
        }

        public void RefreshListView()
        {
            listViewTours.ItemsSource = null;
            listViewTours.ItemsSource = Pages.AddPage._tours;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.AddPage);

        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.LoginPage);
        }

        private void listViewTours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonErase.IsEnabled = listViewTours.SelectedIndex != -1;
            buttonEdit.IsEnabled = listViewTours.SelectedIndex != -1;
        }

        private void buttonErase_Click(object sender, RoutedEventArgs e)
        {
            if (listViewTours.SelectedIndex != -1)
            {
                Pages.AddPage._tours.RemoveAt(listViewTours.SelectedIndex);
                RefreshListView();
                Pages.ToursPage.RefreshListView();
                SerializeData();
            }
        }

        public void SerializeData()
        {
            File.Delete(fileName);
            Data data = new Data();
            data.Tours = Pages.AddPage._tours;

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Data));
                xml.Serialize(fs, data);
            }
        }

        public Data DeserializeData()
        {
            if (File.Exists(fileName))
            {
                Data data;
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Data));
                    data = (Data)xml.Deserialize(fs);
                    Pages.AddPage._tours = data.Tours;
                    listViewTours.ItemsSource = data.Tours;
                    Pages.ToursPage.listViewShowTours.ItemsSource = data.Tours;
                    return data;
                }
            }
            else
            {
                MessageBox.Show("Файл не существует либо не содержит информации!", "Ошибка");
                return null;
            }
        }

        public Hotels selectedHotel;
        public CityTo selectedCityTo;
        public Tours selectedTour;
        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (listViewTours.SelectedIndex != -1)
            {
                selectedTour = Pages.AddPage._tours[listViewTours.SelectedIndex];
                EditPage editPage = new EditPage();
                foreach (var tour in Pages.AddPage._tours)
                {
                    editPage.cityFromBox.Text = tour.CityFrom;
                    editPage.cityToBox.Text = tour.CityTo.Name;
                    editPage.countryBox.Text = tour.CityTo.Country;
                    editPage.priceBox.Text = Convert.ToString(tour.Price);
                    editPage.dateGoPicker.SelectedDate = Convert.ToDateTime(tour.DateGo);
                    editPage.dateBackPicker.SelectedDate = Convert.ToDateTime(tour.DateBack);
                    editPage.hotelBox.Text = tour.CityTo.Hotel.HotelName;
                    editPage.roomPrice1Box.Text = Convert.ToString(tour.CityTo.Hotel.RoomPrice1);
                    editPage.roomPrice2Box.Text = Convert.ToString(tour.CityTo.Hotel.RoomPrice2);
                    editPage.roomPrice3Box.Text = Convert.ToString(tour.CityTo.Hotel.RoomPrice3);
                }
                NavigationService.Navigate(editPage);
            }
        }
    }
    }
