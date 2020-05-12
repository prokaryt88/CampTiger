#pragma checksum "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7692fc2f3cb50524a489ddb11329df3b36139ec"
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
#line 2 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
           [Authorize(Roles = "admin, groupleader")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RequestManagement")]
    public partial class RequestManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
       
    List<AspNetUsers> users;
    List<Event> events;
    List<UserEvent> records;
    List<Group> groups;
    String userId;

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        users = await userService.GetAspNetUsersAsync();
        events = await eventService.GetEventsAsync();
        records = await userEventService.GetUserEventAsync();
        groups = await groupService.GetGroupAsync();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var currentUser = await UserManager.GetUserAsync(user);
        userId = currentUser.Id;
    }

    protected async Task AcceptRequest(AspNetUsers user, Event activity)
    {
        UserEvent g = new UserEvent()
        {
            EventId = activity.EventId,
            UserId = user.Id,
            Approved = true
        };

        await userEventService.UpdateUserEventAsync(activity.EventId, user.Id, g);
        await load();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GroupService groupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserEventService userEventService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventService eventService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
