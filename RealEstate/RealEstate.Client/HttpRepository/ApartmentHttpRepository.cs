using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public class ApartmentHttpRepository : HttpRepositoryBase, IHttpRepository<Apartment>
    {
        public ApartmentHttpRepository(HttpClient client)
           : base(client)
        {
        }


        //passing an entire URI to the server endpoint
        public async Task<List<Apartment>> GetAll()
        {
            var response = await _client.GetAsync("https://localhost:5021/api/apartments");
            var content = await response.Content.ReadAsStringAsync();
            var apartments = JsonSerializer.Deserialize<List<Apartment>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return apartments;
        }
    }
}
