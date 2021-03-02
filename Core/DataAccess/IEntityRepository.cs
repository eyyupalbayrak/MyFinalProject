using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //class = referans tip olabilir.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Expression<Func<T,bool>> filter=null linq yazmak için kullanıyoruz
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
