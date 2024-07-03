using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    public static class OrderHelper
    {
        /// <summary>
        /// Обобщенный метод расширения CalculateTotalPrice для класса Order, который рассчитывает общую стоимость заказа
        /// </summary>
        /// <typeparam name="TDelivery"></typeparam>
        /// <typeparam name="TStruct"></typeparam>
        /// <param name="order"></param>
        /// <returns></returns>
        public static decimal CalculateTotalPrice<TDelivery, TStruct>(this Order<TDelivery, TStruct> order) where TDelivery : Delivery
        {
            decimal totalPrice = 0;
            foreach (var product in order.Products)
            {
                totalPrice += product.Price * product.Quantity;
            }
            return totalPrice;
        }
        /// <summary>
        /// метод расширения DisplayOrderInfo для класса Order, который выводит информацию о заказе
        /// </summary>
        /// <typeparam name="TDelivery"></typeparam>
        /// <typeparam name="TStruct"></typeparam>
        /// <param name="order"></param>
        public static void DisplayOrderInfo<TDelivery, TStruct>(this Order<TDelivery, TStruct> order) where TDelivery : Delivery
        {
            Console.WriteLine($"Заказ №{order.Number}");
            Console.WriteLine($"Адрес доставки: {order.Delivery.GetAddress()}");
            Console.WriteLine("Список товаров:");
            foreach (var product in order.Products)
            {
                Console.WriteLine($"{product.Name} - {product.Price} руб. x {product.Quantity} шт.");
            }
            Console.WriteLine($"Общая стоимость: {order.CalculateTotalPrice()} руб.");
        }
    }
}
