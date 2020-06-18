using LagarAppE04.ShopHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagarAppE04.ProductHelper
{
    public class Product
    {
        private decimal _price;
        //public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {

                    throw new ArgumentNullException(nameof(Name));
                }
                _price = value;
            }
        }

        public string ManuFacturer { get; set; }
        //public List<Shop> Shops { get; set; } = new List<Shop>();

        public override string ToString()
        {
            return Name + " " + "\t" + Price + "\t"+ ManuFacturer + " " ;
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
