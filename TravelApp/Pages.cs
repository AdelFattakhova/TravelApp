using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    static class Pages
    {
        private static MainPage _mainPage = new MainPage();
        private static LoginPage _loginPage = new LoginPage();
        private static AddPage _addPage = new AddPage();
        private static ListPage _listPage = new ListPage();
        private static ToursPage _toursPage = new ToursPage();

        public static LoginPage LoginPage
        {
            get
            {
                return _loginPage;
            }
        }

        public static MainPage MainPage
        {
            get
            {
                return _mainPage;
            }
        }

        public static AddPage AddPage
        {
            get
            {
                return _addPage;
            }
        }

        public static ListPage ListPage
        {
            get
            {
                return _listPage;
            }
        }

        public static ToursPage ToursPage
        {
            get
            {
                return _toursPage;
            }
        }
    }
}
