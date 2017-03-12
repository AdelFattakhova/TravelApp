using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    class Tours
    {
        private string _cityFrom;

        public string CityFrom
        {
            get { return _cityFrom; }
            set { _cityFrom = value; }
        }
        
        private CityTo _cityTo;

        public CityTo CityTo
        {
            get { return _cityTo; }
            set { _cityTo = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Tours(string cityFrom, CityTo cityTo, double price, DateTime date)
        {
            _cityFrom = cityFrom;
            _cityTo = cityTo;
            _price = price;
            _date = date;
        }
    }
}
