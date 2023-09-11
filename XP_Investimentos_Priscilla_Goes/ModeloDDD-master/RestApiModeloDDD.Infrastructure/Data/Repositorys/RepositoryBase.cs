using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys;
public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{

    private readonly SqlContext sqlContext;

    public RepositoryBase(SqlContext sqlContext)
    {
        this.sqlContext = sqlContext;
    }
    public void Add(TEntity obj)
    {
        try
        {
            sqlContext.Set<TEntity>().Add(obj);
            sqlContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public IEnumerable<TEntity> GetAll()
    {
        return sqlContext.Set<TEntity>().ToList();
    }

    public IEnumerable<TEntity> GetByDetalhes()
    {
        return sqlContext.Set<TEntity>().ToList();
    }

    public TEntity GetByDetalhes(int id)
    {
        return sqlContext.Set<TEntity>().Find(id);
    }

    public TEntity GetById(int id)
    {
        return sqlContext.Set<TEntity>().Find(id);
    }

    public void Remove(TEntity obj)
    {
        try
        {
            sqlContext.Set<TEntity>().Remove(obj);
            sqlContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Update(TEntity obj)
    {
        try
        {
            sqlContext.Entry(obj).State = EntityState.Modified;
            sqlContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

