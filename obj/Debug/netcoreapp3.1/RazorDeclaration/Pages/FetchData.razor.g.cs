#pragma checksum "C:\Users\Alex\source\repos\CampTiger\CampTiger\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b47698217df5fcbc87f02b478d13100bdab8fafe"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CampTiger.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using CampTiger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex\source\repos\CampTiger\CampTiger\_Imports.razor"
using CampTiger.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\source\repos\CampTiger\CampTiger\Pages\FetchData.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\source\repos\CampTiger\CampTiger\Pages\FetchData.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FetchData")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Alex\source\repos\CampTiger\CampTiger\Pages\FetchData.razor"
            
    List<User> users;

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        users = await userService.GetUsersAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
    }
}
#pragma warning restore 1591
