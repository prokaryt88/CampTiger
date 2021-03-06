#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\FamilyManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b7c0eea20915659deed56eb32a60d0d5868221"
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
#line 1 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using CampTiger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
using CampTiger.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\FamilyManagement.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\FamilyManagement.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\FamilyManagement.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\FamilyManagement.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FamilyManagement")]
    public partial class FamilyManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\FamilyManagement.razor"
           
    List<Event> events;
    List<AspNetUsers> users;
    List<Group> groups;
    List<Family> families;
    List<UserFamily> records;
    string userId;
    string familyId;
    string leader;
    string Group;
    string name;
    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    Family activity;

    protected async Task Insert()
    {
        familyId = Guid.NewGuid().ToString();

        Family e = new Family()
        {
            FamilyId = familyId,
            LeaderId = leader,
            Name = name
        };
        await familyService.InsertFamilyAsync(e);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected void Add()
    {
        //ClearFields();
        mode = MODE.Add;
    }

    protected void ClearFields()
    {
        familyId = string.Empty;
        leader = string.Empty;
        name = string.Empty;
    }

    protected async Task Update()
    {
        Family e = new Family()
        {
            FamilyId = familyId,
            LeaderId = leader,
            Name = name
        };

        await familyService.UpdateFamilyAsync(familyId, e);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Delete()
    {
        await familyService.DeleteFamilyAsync(familyId);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Show(string id)
    {
        activity = await familyService.GetFamilyByIdAsync(id);
        familyId = activity.FamilyId;
        leader = activity.LeaderId;
        name = activity.Name;
        mode = MODE.EditDelete;
    }

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        users = await aspNetUsersService.GetAspNetUsersAsync();
        families = await familyService.GetFamilyAsync();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var currentUser = await UserManager.GetUserAsync(user);
        userId = currentUser.Id;
    }

    async Task LookUp()
    {
        await JsRuntime.InvokeVoidAsync("mySearch");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserFamilyService userFamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FamilyService familyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService aspNetUsersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
