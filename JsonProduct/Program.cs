using JsonProduct.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Json Serialize
            Product tshirt = new Product() { Id = 1, Name = "Everlane", Price = 22.90 };
            Product trousers = new Product() { Id = 2, Name = "Jack & Jones", Price = 25 };
            Product coat = new Product() { Id = 3, Name = "The North Face", Price = 80.75 };
            Product shoes = new Product() { Id = 4, Name = "Nike", Price = 60.50 };


            OrderItem item = new OrderItem() { Id = 1, Product = tshirt, Count = 3 };
            item.TotalPrice = Math.Round(tshirt.Price * item.Count, 2);

            OrderItem item2 = new OrderItem() { Id = 2, Product = trousers, Count = 1 };
            item2.TotalPrice = Math.Round(trousers.Price * item2.Count, 2);

            OrderItem item3 = new OrderItem() { Id = 3, Product = shoes, Count = 2 };
            item3.TotalPrice = Math.Round(shoes.Price * item3.Count, 2);

            OrderItem item4 = new OrderItem() { Id = 4, Product = coat, Count = 6 };
            item4.TotalPrice = Math.Round(coat.Price * item4.Count, 2);

            List<OrderItem> orderItems1 = new List<OrderItem>();
            orderItems1.Add(item);
            orderItems1.Add(item2);
            orderItems1.Add(item3);
            orderItems1.Add(item4);

            Order order1 = new Order() { Id = 1, OrderItems = orderItems1 };

            var json = JsonConvert.SerializeObject(order1);
            Console.WriteLine(json);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\asger\Desktop\Tasks\JsonProduct\JsonProduct\JsonFiles\Product.json"))
            {
                sw.WriteLine(json);
            }
            #endregion

            #region Json Deserialize
            //string result;
            //using (StreamReader sr = new StreamReader(@"C:\Users\asger\Desktop\Tasks\JsonProduct\JsonProduct\JsonFiles\Product.json"))
            //{
            //    result = sr.ReadToEnd();
            //}
            //Order order = JsonConvert.DeserializeObject<Order>(result);
            //foreach (var item in order.OrderItems)
            //{
            //    Console.WriteLine(item.Product.Name);
            //}
            #endregion

        }
    }
}
