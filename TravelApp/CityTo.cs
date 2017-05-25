using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class CityTo
    {
        public string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public Hotels _hotel;

        public Hotels Hotel
        {
            get { return _hotel; }
            set { _hotel = value; }
        }

        public CityTo()
        {

        }

        public CityTo(string name, string country, Hotels hotel)
        {
            _name = name;
            _country = country;
            _hotel = hotel;
        }
    }
}
