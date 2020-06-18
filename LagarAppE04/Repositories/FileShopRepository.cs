using LagarAppE04.Helpers;
using LagarAppE04.ShopHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LagarAppE04.Repositories
{
    public class FileShopRepository : IShopRepository
    {
        private readonly List<Shop> _shops;

        public FileShopRepository()
        {
            var path = Path.Combine(FileHelper.GetUserHomePath(), ".Files", "Shops.json");
            _shops = File.Exists(path) ? FileHelper.LoadFromJson<Shop>(path).ToList() : new List<Shop>();
        }
        public IEnumerable<Shop> GetAll()
        {
            return _shops;
        }

        public void Insert(Shop product)
        {
            _shops.Add(product);
            Save();
        }

        public void Delete (Shop shop)
        {
            _shops.Remove(shop);
            Save();
        }

        public void Save()
        {
            var path = Path.Combine(FileHelper.GetUserHomePath(), ".Files", "Shops.json");
            FileHelper.SaveToJson(path, _shops);
        }

        public Shop GetByProductName(string productName)
        {
            throw new NotImplementedException();
        }

        public Shop GetByManuFacturerName(string manufacturerName)
        {
            throw new NotImplementedException();
        }

        public void Upload(Shop product)
        {
            throw new NotImplementedException();
        }
    }
}
