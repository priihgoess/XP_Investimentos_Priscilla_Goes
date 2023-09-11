using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(T obj);

        IEnumerable<T> GetAll();
        IEnumerable<T> GetByDetalhes(int id);

        T GetById(int id);
    }
}