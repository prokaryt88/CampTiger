#pragma checksum "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4316c3cf2c8b3eeac5a94ebd29efd328bedf6cc8"
// <auto-generated/>
#pragma warning disable 1591
namespace CampTiger.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using CampTiger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex\Documents\GitHub\CampTiger\_Imports.razor"
using CampTiger.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
           [Authorize(Roles = "normal")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyGroups")]
    public partial class MyGroups : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Groups</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Groups you have joined</p>\n\n");
#nullable restore
#line 19 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
 if (group == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 22 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
}

else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-hover");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Group Name</th>\n                <th>Description</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 34 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
             foreach (var g in group)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
                 foreach (var ug in usergroup)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
                     if (g.GroupId == ug.GroupId && ug.UserId == userId)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                        ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 41 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
                                 g.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 42 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
                                 g.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                            ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\n                                ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
                                                                          (() => Delete(g.GroupId, userId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Leave");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#nullable restore
#line 47 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
#nullable restore
#line 52 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\MyGroups.razor"
            
        List<AspNetUsers> users;
        List<Group> group;
        List<UserGroups> usergroup;
        String userId;

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        users = await userService.GetAspNetUsersAsync();
        group = await groupService.GetGroupAsync();
        usergroup = await userGroupService.GetUserGroupAsync();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var currentUser = await UserManager.GetUserAsync(user);
        userId = currentUser.Id;
    }

    protected async Task Delete(string gID, string uId)
    {
        await userGroupService.DeleteUserGroupAsync(gID, uId);
        await load();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserGroupService userGroupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GroupService groupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
