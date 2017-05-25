using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace TravelApp
{
    public class ProgramData
    {

        private List<Tours> _tours;

        public List<Tours> Tours
        {
            get { return _tours; }
            set { _tours = value; }
        }

        private List<CityTo> _country;

        public List<CityTo> Country
        {
            get { return _country; }
            set { _country = value; }
        }

        private List<Hotels> _hotels;

        public List<Hotels> Hotels
        {
            get { return _hotels; }
            set { _hotels = value; }
        }

    }
        public class Program
    {

        public static void SerializeData()
        {            
            List<Hotels> hotels = new List<Hotels>();

            List<CityTo> countries = new List<CityTo>();

            List<Tours> tours = new List<Tours>();

            ProgramData data = new ProgramData();
            data.Tours = tours;
            data.Country = countries;
            data.Hotels = hotels;

            using (var fs = new FileStream("tours.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(ProgramData));
                xml.Serialize(fs, data);
            }
        }

        public static ProgramData DeserializeData()
        {
            ProgramData data;
            using (var fs = new FileStream("tours.xml", FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(typeof(ProgramData));
                data = (ProgramData)xml.Deserialize(fs);
            }
            return data;
        }
    }
}
