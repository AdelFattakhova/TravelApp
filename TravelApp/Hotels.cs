using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    class Hotels
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _roomType;

        public string RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }
        
    }
}
