#pragma checksum "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65f0e2318686407aefe39894b1c4a10035744dc5"
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
#line 2 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
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
            __builder.AddMarkupContent(0, "<h3>Group Sign Up</h3>\n\n");
#nullable restore
#line 15 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
 if (groups == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em> Loading...</em></p>\n");
#nullable restore
#line 18 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-hover");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<thead>\n            <tr>\n                <th>Name</th>\n                <th>Description</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 29 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
             foreach (var sect in groups)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 32 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
                         sect.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
                         sect.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
                                                                  (() => Insert(sect))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Sign-Up");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 41 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupSignUp.razor"
       

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
