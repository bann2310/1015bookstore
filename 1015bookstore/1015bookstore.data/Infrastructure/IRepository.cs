﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.data.Infrastructure
{
    public interface IRepository<T> where T : class 
    {
        void Add(T entity);

        void Update(int id, T entity);

        void Delete(T entity);

        void Delete(int id);

        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetById(int id);

        T GetByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}
