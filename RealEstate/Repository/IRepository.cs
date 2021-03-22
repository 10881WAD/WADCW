using Entities.Features;
using Repository.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// only 2 methods have been implemented so far
    /// GetAll method will be changed when Pagination will be applied
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        
        Task<PagedList<T>> GetAll(EntityParameters entityParameters);
        Task<T> GetById(int id);

        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
