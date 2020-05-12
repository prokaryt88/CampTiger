#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a654036436ba8e02f85ca61403b46cecd1bf27ee"
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
#line 2 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventManagement.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventManagement.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventManagement.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventManagement.razor"
           [Authorize(Roles = "groupleader")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EventManagement")]
    public partial class EventManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 149 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventManagement.razor"
           
    List<Event> events;
    List<AspNetUsers> users;
    List<Group> groups;
    string userId;
    string eventId;
    string leader;
    string Group;
    string name;
    string description;
    string date;
    string time;
    string capacity;
    Boolean leadsGroup = true;
    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    Event activity;

    protected async Task Insert()
    {
        eventId = Guid.NewGuid().ToString();

        Event e = new Event()
        {
            EventId = eventId,
            Leader = userId,
            Group = Group,
            Name = name,
            Description = description,
            Date = date,
            Time = time,
            Capacity = capacity
        };
        await eventService.InsertEventAsync(e);
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
        eventId = string.Empty;
        Group = string.Empty;
        name = string.Empty;
        description = string.Empty;
        date = string.Empty;
        time = string.Empty;
        capacity = string.Empty;
    }

    protected async Task Update()
    {
        Event ev = new Event()
        {
            EventId = eventId,
            Leader = leader,
            Group = Group,
            Name = name,
            Description = description,
            Date = date,
            Time = time,
            Capacity = capacity
        };

        await eventService.UpdateEventAsynC(eventId, ev);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Delete()
    {
        await eventService.DeleteEventAsync(eventId);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Show(string id)
    {
        activity = await eventService.GetEventByIdAsync(id);
        eventId = activity.EventId;
        Group = activity.Group;
        leader = activity.Leader;
        name = activity.Name;
        description = activity.Description;
        date = activity.Date;
        time = activity.Time;
        capacity = activity.Capacity;
        mode = MODE.EditDelete;
    }

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        events = await eventService.GetEventsAsync();
        users = await aspNetUsersService.GetAspNetUsersAsync();
        groups = await groupService.GetGroupAsync();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GroupService groupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService aspNetUsersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventService eventService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
