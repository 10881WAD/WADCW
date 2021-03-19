using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public class RegionHttpRepository : HttpRepositoryBase, IHttpRepository<Region>
    {
        public RegionHttpRepository(HttpClient client)
           : base(client)
    {
    }


    //passing an entire URI to the server endpoint
    public async Task<List<Region>> GetAll()
    {
        var response = await _client.GetAsync("https://localhost:5021/api/regions");
        var content = await response.Content.ReadAsStringAsync();
        var regions = JsonSerializer.Deserialize<List<Region>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return regions;
    }
}
}
