using LagarAppE04.ProductHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagarAppE04.Helpers
{
    public class ConsoleHelper
    {
        public static Product NewProduct()
        {
            Console.WriteLine("Please enter product name : ");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter Price (,) : ");
            var price = decimal.Parse(Console.ReadLine());

            Product product = new Product()
            {
                Name = name,
                Price = price
            };

            return product;
        }
    }
}
