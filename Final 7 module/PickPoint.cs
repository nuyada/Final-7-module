using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    public class PickPoint
    {
        private string name;
        private Address address;
        private string phoneNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length < 10)
                {
                    Console.WriteLine("Неправильно введен номер телефона");
                }
                else phoneNumber = value;
            }
        }

    }
}
