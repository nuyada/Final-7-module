using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    public class PickPointDelivery: Delivery
    {
        private PickPoint pickPoint;

        public PickPoint PickPoint
        {
            get { return pickPoint; }
            set { pickPoint = value; }
        }
        public override string GetAddress()
        {
            return PickPoint.Address.GetFullAddress();
        }
        public override void Deliver()
        {
            Console.WriteLine("Доставка в пункт выдачи выполнена.");
        }
    }
}
