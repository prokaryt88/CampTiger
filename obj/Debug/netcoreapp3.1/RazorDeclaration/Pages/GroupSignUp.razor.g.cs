#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\GroupSignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65f0e2318686407aefe39894b1c4a10035744dc5"
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
#line 2 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\GroupSignUp.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\GroupSignUp.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\GroupSignUp.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\GroupSignUp.razor"
           [Authorize(Roles = "normal")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroupSignUp")]
    public partial class GroupSignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\GroupSignUp.razor"
       

    List<Group> groups;
    string groupId;
    string userId;
    private enum MODE { None, Add };
    MODE mode = MODE.None;
    Group group;
    public Group current { get; set; } = new Group();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        groups = await groupService.GetGroupAsync();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var currentUser = await UserManager.GetUserAsync(user);
        userId = currentUser.Id;
    }

    protected async Task Insert(Group activity)
    {
        UserGroups g = new UserGroups()
        {
            GroupId = activity.GroupId,//groupId,
            UserId = userId
        };
        await userGroupService.InsertUserGroupAsync(g);
        await load();
        mode = MODE.None;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserGroupService userGroupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GroupService groupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
