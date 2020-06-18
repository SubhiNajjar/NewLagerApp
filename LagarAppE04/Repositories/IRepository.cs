using LagarAppE04.ProductHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagarAppE04.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetByProductName(string productName);

        T GetByManuFacturerName(string manufacturerName);

        void Insert(T product);

        void Upload(T product);

        void Delete(T product);

        void Save();

    }
}
