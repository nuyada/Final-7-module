using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
     abstract public class Delivery
    {
        protected string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public abstract string GetAddress();
        public abstract void Deliver();
    }
}
