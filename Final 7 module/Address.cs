using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    public class Address
    {
        private string country;
        private string city;
        private string street;
        private string building;
        private string apartment;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string Building
        {
            get { return building; }
            set { building = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

    }
}
