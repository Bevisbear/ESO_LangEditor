﻿using Core.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<PagedList<T>> GetAllAsync(PageParameters pageParameters);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression);
        Task<IQueryable<TType>> SelectByConditionWithDistinctAsync<TType>(Expression<Func<T, TType>> expression);
        void Create(T entity);
        void CreateList(List<T> entity);
        void Update(T entity);
        void UpdateList(List<T> entity);
        void Delete(T entity);
        void DeleteList(List<T> entity);
        Task<bool> SaveAsync();
    }
}
