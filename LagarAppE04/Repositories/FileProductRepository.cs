using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using LagarAppE04.Helpers;
using LagarAppE04.JsonFileHelper;
using LagarAppE04.ProductHelper;
using System;
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


        public Product GetByProductName(string produktName)
        {
            Product product = new Product();
            return product = _products.Find(x => x.Name == produktName);
        }

        public Product GetByManuFacturerName(string manufacturerName)
        {
            Product product = new Product();
            return product = _products.Find(m => m.ManuFacturer == manufacturerName);
        }

        public void Delete(Product product)
        {
            //return _products.RemoveAt(x => x.Name == Product)
            int index = _products.FindIndex(p => p.Name == product.Name);
            if (index >= 0)
            {
                _products.RemoveAt(index);
                Save();
            }
            else
                Console.WriteLine("Product Not Found");
        }

        public void Upload (Product product)
        {
            int index = _products.FindIndex(p => p.Name == product.Name);
            if (index >= 0)
            {
                _products.Add(product);
                Save();
            }

        }

        public void Save()
        {
            // Path ... Add Your Path In PC 
            var path = Path.Combine(FileHelper.GetUserHomePath(), ".Files", "product4.json");
            FileHelper.SaveToJson(path, _products);
        }
    }
}
