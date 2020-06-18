using DocumentFormat.OpenXml.Bibliography;
using LagarAppE04.Helpers;
using LagarAppE04.JsonFileHelper;
using LagarAppE04.ProductHelper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using static System.Console;

namespace LagarAppE04.Filters
{
    public class ProductFilter
    {
        internal void SearchByPrice(decimal maxPrice, IEnumerable<Product> products)
        {
            var query = products.Where(s => s.Price < maxPrice).OrderByDescending(p => p.Price).Take(10);
            if (!query.Any())
            {
                WriteLine($"No products found with price less than {maxPrice}");
            }
            else
            {
                WriteLine($"\n{"Product",-20}  {"Price",10}");
                foreach(var q in query)
                {
                    WriteLine($"{q.Name.PadRight(20)}  {q.Price,10}");
                    WriteLine("-----");
                }
            }
        }

    }
}
