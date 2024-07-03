using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    public class ShopDelivery : Delivery
    {
        private Shop shop;

        public Shop Shop
        {
            get { return shop; }
            set { shop = value; }
        }
        public override string GetAddress()
        {
            return Shop.Address.GetFullAddress();
        }
        public override void Deliver()
        {
            Console.WriteLine("Доставка в магазин выполнена.");
        }
    }
   
}
