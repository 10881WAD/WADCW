using Entities.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Components.ApartmentTable
{
    public partial class ApartmentTable
    {
        [Parameter]
        public List<Apartment> Apartments { get; set; }
    }

}
