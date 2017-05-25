using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class Tours
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

        private string _dateGo;

        public string DateGo
        {
            get { return _dateGo; }
            set { _dateGo = value; }
        }

        private string _dateBack;

        public string DateBack
        {
            get { return _dateBack; }
            set { _dateBack = value; }
        }

        public Tours()
        {

        }

        public Tours(string cityFrom, CityTo cityTo, double price, string dateGo, string dateBack)
        {
            _cityFrom = cityFrom;
            _cityTo = cityTo;
            _price = price;
            _dateGo = dateGo;
            _dateBack = dateBack;
        }

    }
}
