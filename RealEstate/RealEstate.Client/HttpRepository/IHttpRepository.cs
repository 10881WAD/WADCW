﻿using Entities.Features;
using RealEstate.Client.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public interface IHttpRepository<T> where T : class
    {
        Task<PagingResponse<T>> GetAll(EntityParameters entityParameters);
        Task CreateAsync(T entity);
        Task<string> UploadImage(MultipartFormDataContent content);
    }
}
