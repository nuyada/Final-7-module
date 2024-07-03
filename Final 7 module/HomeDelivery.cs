using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    public class HomeDelivery: Delivery
    {
        private Address deliveryAddress;
        private Courier courier;

        public Address DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        public Courier Courier
        {
            get { return courier; }
            set { courier = value; }
        }
        public override void Deliver()
        {
            Console.WriteLine("Доставка на дом выполнена курьером.");
        }
    }
}
