#pragma checksum "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Pages\Apartments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe697e572ac8ee8c80443efa48f1b01a1a698ac"
// <auto-generated/>
#pragma warning disable 1591
namespace RealEstate.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Pages\Apartments.razor"
using RealEstate.Client.Components.ApartmentTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Pages\Apartments.razor"
using RealEstate.Client.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apartments")]
    public partial class Apartments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <a href=\"/createProduct\">Create Product</a>\r\n    </div>\r\n</div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<RealEstate.Client.Components.ApartmentTable.ApartmentTable>(7);
            __builder.AddAttribute(8, "Apartments", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Entities.Models.Apartment>>(
#nullable restore
#line 12 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Pages\Apartments.razor"
                                    ApartmentList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenComponent<RealEstate.Client.Components.Page>(18);
            __builder.AddAttribute(19, "MetaData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Entities.Features.MetaData>(
#nullable restore
#line 17 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Pages\Apartments.razor"
                        MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Pages\Apartments.razor"
                                          2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 17 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Pages\Apartments.razor"
                                                           SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
