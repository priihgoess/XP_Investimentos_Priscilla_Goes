using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(T obj);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetByDetalhes();

        T GetById(int id);
        T GetByDetalhes(int id);
         
    }
}