using Entities.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Components.HouseTable
{
    public partial class HouseTable
    {
        [Parameter]
        public List<House> Houses { get; set; }
    }
}
