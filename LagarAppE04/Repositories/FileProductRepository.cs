using DocumentFormat.OpenXml.Drawing.Charts;
using LagarAppE04.Helpers;
using LagarAppE04.JsonFileHelper;
using LagarAppE04.ProductHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LagarAppE04.Repositories
{
    public class FileProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public FileProductRepository()
        {

            // Path ... Add Your Path In PC 
            var path = Path.Combine(FileHelper.GetUserHomePath(), ".Files", "product4.json"); 
            _products = File.Exists(path) ? FileHelper.LoadFromJson<Product>(path).ToList() : new List<Product>();
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
        public void Insert(Product product)
        {
            _products.Add(product);
            Save();
        }

        // Case 3 : Option For Find ??
        //public Product GetByProductName(string productName)
        //{
        //    Product product = new Product();
        //    return product = _products.Find(x => x.Name == productName);
        //}


        public void Save()
        {
            // Path ... Add Your Path In PC 
            var path = Path.Combine(FileHelper.GetUserHomePath(), ".Files", "product4.json");
            FileHelper.SaveToJson(path, _products);
        }
    }
}
