using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    public class PriorityOrder<TDelivery, TStruct> : Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public PriorityLevel PriorityLevel { get; set; }

        public PriorityOrder(TDelivery delivery, int number, string description, List<Product> products, PriorityLevel priorityLevel)
            : base(delivery, number, description, products)
        {
            PriorityLevel = priorityLevel;
        }
        /// <summary>
        /// рассчитывает ожидаемое время доставки в зависимости от приоритета заказа. Если приоритет высокий, то время доставки составляет 2 часа, если средний - 4 часа, а если низкий - 6 часов.
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetDeliveryTime()
        {
            TimeSpan deliveryTime;

            if (PriorityLevel == PriorityLevel.High)
            {
                deliveryTime = TimeSpan.FromHours(2);
            }
            else if (PriorityLevel == PriorityLevel.Medium)
            {
                deliveryTime = TimeSpan.FromHours(4);
            }
            else
            {
                deliveryTime = TimeSpan.FromHours(6);
            }

            return deliveryTime;
        }
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }
}

