using System;
using System.Collections.Generic;
using System.Text;

namespace LagarAppE04.ProductHelper
{
    public class Product
    {
        //public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return Name + " " + "\t" + Price;
        }


        ////private string _name;
        //private decimal _price;


        //public string Name { get; set; }

        //[JsonProperty("Price")]
        //public string Price { get; set;}

        //[JsonProperty("ManuFacturer")]
        //public string ManuFacturer { get; set; }

        //public override string ToString()
        //{
        //    return $"{Name} \t {Price} $\t {ManuFacturer}";
        //}

    }
}
