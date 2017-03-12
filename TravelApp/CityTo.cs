using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    class CityTo
    {
        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        private Hotels _hotel;

        public Hotels Hotel
        {
            get { return _hotel; }
            set { _hotel = value; }
        }

    }
}
