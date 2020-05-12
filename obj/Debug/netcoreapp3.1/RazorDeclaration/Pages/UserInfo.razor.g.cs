#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\UserInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "311e1b95fef879bfe392cff5661344e83ffaffbf"
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
#line 2 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\UserInfo.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\UserInfo.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\UserInfo.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\UserInfo.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\UserInfo.razor"
           [Authorize(Roles = "groupleader, normal")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserInfo")]
    public partial class UserInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\UserInfo.razor"
       

    List<AspNetUsers> Users;
    string userId;
    string firstName;
    string lastName;
    string address;
    string state;
    string zip;
    string phone;
    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    AspNetUsers User;
    bool ShowPopup = false;
    IdentityUser objUser = new IdentityUser();

    string CurrentUserRole { get; set; } = "User";

    List<string> Options = new List<string>() { "User", "Group Leader", "Admin" };
    string strError = "";

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {

        Users = await userService.GetAspNetUsersAsync();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var currentUser = await _UserManager.GetUserAsync(user);
        userId = currentUser.Id;
    }

    protected void ClearFields()
    {
        firstName = string.Empty;
        lastName = string.Empty;
        address = string.Empty;
        state = string.Empty;
        zip = string.Empty;
        phone = string.Empty;
    }

    async Task SaveUser()

    {
        var NewUser = new IdentityUser
        {
            UserName = objUser.Email,
            Email = objUser.Email
        };

        if (!userService.AspNetUsersExistsEmail(NewUser.Email))
        {
            var CreateResult = await _UserManager.CreateAsync(NewUser, objUser.PasswordHash);

            await _UserManager.AddToRoleAsync(NewUser, CurrentUserRole);

            ShowPopup = false;
            Users = await userService.GetAspNetUsersAsync();
        }
    }

    protected async Task Update()
    {

        AspNetUsers u = new AspNetUsers()
        {
            FirstName = firstName,
            LastName = lastName,
            Address = address,
            State = state,
            Zip = zip,
            Phone = phone
        };

        await userService.UpdateAspNetUsersAsync(userId, u);
        var change = await _UserManager.FindByIdAsync(userId);

        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Show(string id)
    {
        User = await userService.GetAspNetUsersByIdAsync(id);
        userId = User.Id;
        firstName = User.FirstName;
        lastName = User.LastName;
        address = User.Address;
        state = User.State;
        zip = User.Zip;
        phone = User.Phone;
        mode = MODE.EditDelete;
    }

    void ClosePopup()
    {
        ShowPopup = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
