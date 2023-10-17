using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Module35_SocialNetwork.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}