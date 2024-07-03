using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    public class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        private TDelivery delivery;
        private int number;
        private string description;

        private List<Product> products;

        public TDelivery Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public Order(TDelivery delivery, int number, string description, List<Product> products)
        {
            Delivery = delivery;
            Number = number;
            Description = description;
            Products = products;
        }
        /// <summary>
        /// Метод DisplayAddress класса Order, который выводит адрес доставки заказа
        /// </summary>
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
        /// <summary>
        /// Метод FindProduct класса Order, который ищет товар в списке товаров заказа по его названию
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public Product FindProduct<T>(T name) where T : IComparable<T>
        {
            foreach (var product in Products)
            {
                if (product.Name.CompareTo((T)name) == 0)
                {
                    return product;
                }
            }
            return null;
        }
        public Product this[int index]
        {
            get
            {
                if (index < 0 || index >= Products.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return Products[index];
            }
            set
            {
                if (index < 0 || index >= Products.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                Products[index] = value;
            }
        }

    }
}

