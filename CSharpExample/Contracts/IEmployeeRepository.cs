using System.Collections.Generic;

namespace CSharpExample.Contracts
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T Update(T employee);

        T Insert(T employee);

        void Delete(T employee);
    }
}