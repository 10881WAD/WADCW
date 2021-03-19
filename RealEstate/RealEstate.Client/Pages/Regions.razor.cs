using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages
{
    public partial class Regions
    {
        public List<Region> RegionList { get; set; } = new List<Region>();

        [Inject]//we are injectiong the interface to call the GetAll method
        public IHttpRepository<Region> RegionRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            RegionList = await RegionRepo.GetAll();

        }
    }
}
