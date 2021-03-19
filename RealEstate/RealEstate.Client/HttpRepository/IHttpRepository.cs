using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public interface IHttpRepository<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
