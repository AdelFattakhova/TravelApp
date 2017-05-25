using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class Hotels
    {
        public string _name;

        public string HotelName
        {
            get { return _name; }
            set { _name = value; }
        }

        public double _roomPrice1;

        public double RoomPrice1
        {
            get { return _roomPrice1; }
            set { _roomPrice1 = value; }
        }

        public double _roomPrice2;

        public double RoomPrice2
        {
            get { return _roomPrice2; }
            set { _roomPrice2 = value; }
        }

        public double _roomPrice3;

        public double RoomPrice3
        {
            get { return _roomPrice3; }
            set { _roomPrice3 = value; }
        }


        public Hotels()
        {

        }

        public Hotels(string name, double roomPrice1, double roomPrice2, double roomPrice3)
        {
            _name = name;
            _roomPrice1 = roomPrice1;
            _roomPrice2 = roomPrice2;
            _roomPrice3 = roomPrice3;
        }
    }
}
