using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages
{
    public partial class Houses
    {
        public List<House> HouseList { get; set; } = new List<House>();

        [Inject]//we are injectiong the interface to call the GetAll method
        public IHttpRepository<House> HouseRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            HouseList = await HouseRepo.GetAll();

        }
    }
}
