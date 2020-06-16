using LagarAppE04.ProductHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagarAppE04.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();


        // Case 3 : Option For Find
        //Product GetByProductName(string ProductName);
        void Insert(T product);

        void Save();

    }
}
