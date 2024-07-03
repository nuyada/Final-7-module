using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты доставки
            HomeDelivery homeDelivery = new HomeDelivery
            {
                DeliveryAddress = new Address
                {
                    Country = "Россия",
                    City = "Москва",
                    Street = "Ленина",
                    Building = "15",
                    Apartment = "45"
                },
                Courier = new Courier
                {
                    Name = "Иван",
                    PhoneNumber = "89123456789"
                }
            };

            PickPointDelivery pickPointDelivery = new PickPointDelivery
            {
                PickPoint = new PickPoint
                {
                    Name = "Пункт выдачи 1",
                    Address = new Address
                    {
                        Country = "Россия",
                        City = "Москва",
                        Street = "Ленина",
                        Building = "20",
                        Apartment = ""
                    },
                    PhoneNumber = "88005553535"
                }
            };

            ShopDelivery shopDelivery = new ShopDelivery
            {
                Shop = new Shop
                {
                    Name = "Магазин электроники",
                    Address = new Address
                    {
                        Country = "Россия",
                        City = "Москва",
                        Street = "Ленина",
                        Building = "25",
                        Apartment = ""
                    },
                    PhoneNumber = "88005553535"
                }
            };

            // Создаем список товаров
            List<Product> products = new List<Product>
            {
               new Product("Ноутбук", 50000, 1),
               new Product("Смартфон", 30000, 2)
            };

            // Создаем обычный заказ
            Order<HomeDelivery, object> order = new Order<HomeDelivery, object>(homeDelivery, 1, "Обычный заказ", products);
            order.DisplayOrderInfo();

            // Создаем приоритетный заказ
            PriorityOrder<PickPointDelivery, object> priorityOrder = new PriorityOrder<PickPointDelivery, object>(pickPointDelivery, 2, "Приоритетный заказ", products, PriorityLevel.High);
            priorityOrder.DisplayOrderInfo();
            TimeSpan deliveryTime = priorityOrder.GetDeliveryTime();
            Console.WriteLine($"Ожидаемое время доставки: {deliveryTime.TotalHours} часов");

            // Создаем заказ с доставкой в магазин
            Order<ShopDelivery, object> shopOrder = new Order<ShopDelivery, object>(shopDelivery, 3, "Заказ с доставкой в магазин", products);
            shopOrder.DisplayOrderInfo();
            Console.ReadKey();
        }
    }
}
