using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public class HouseHttpRepository : HttpRepositoryBase, IHttpRepository<House>
    {
        public HouseHttpRepository(HttpClient client)
           : base(client)
        {
        }


        //passing an entire URI to the server endpoint
        public async Task<List<House>> GetAll()
        {
            var response = await _client.GetAsync("https://localhost:5021/api/houses");
            var content = await response.Content.ReadAsStringAsync();
            var houses = JsonSerializer.Deserialize<List<House>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return houses;
        }
    }
}
