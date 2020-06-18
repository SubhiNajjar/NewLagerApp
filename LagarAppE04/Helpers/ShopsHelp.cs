using LagarAppE04.ShopHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagarAppE04.Helpers
{
    public class ShopsHelp
    { 
        public static Shop NewShop()
        {
            Console.WriteLine("Please Enter Shop Name:");
            var name = Console.ReadLine();

            Shop shop = new Shop()
            {
                Name = name
            };
            return shop;
        }
    }
}
