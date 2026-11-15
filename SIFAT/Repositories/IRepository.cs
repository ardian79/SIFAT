using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Repositories
{
    internal interface IRepository<T>
    {
        void Insert(T item);
        List<T> GetAll();
        void Update(T item);
        void Delete(int id);
    }
}
