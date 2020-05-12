#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventManagement2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e1e480def3f661239809fcfe338b1a778ffb6a0"
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
#line 1 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\_Imports.razor"
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
#line 2 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EventManagement2")]
    public partial class EventManagement2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

        #searchKey {
            background-position: 10px 10px;
            background-repeat: no-repeat;
            width: 100%;
            font-size: 17px;
            padding: 13px 20px 13px 40px;
            border: 1px solid #ddd;
            margin-bottom: 12px;
        }
    </style>

");
            __builder.AddMarkupContent(1, "<h1> Events</h1>\r\n");
            __builder.AddMarkupContent(2, "<p>Read, Edit, and Delete Event records.</p>\r\n");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "id", "searchKey");
            __builder.AddAttribute(6, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                             LookUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "placeholder", "Search for events by name...");
            __builder.AddAttribute(8, "title", "Type in a name");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.AddMarkupContent(10, "<p>Manage event members:</p>\r\n");
            __builder.AddMarkupContent(11, "<a href=\"MemberAcceptanceManagement\" class=\"btn btn-info\" role=\"button\">Manage Event Members</a>\r\n<br>\r\n");
#nullable restore
#line 31 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
 if (events == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.AddMarkupContent(13, "<p><em> Loading...</em></p>\r\n");
#nullable restore
#line 34 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
}

else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-hover");
            __builder.AddAttribute(17, "id", "list");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, @"<thead>
            <tr>
                <th>Name</th>
                <th>Leader</th>
                <th>Description</th>
                <th>Date</th>
                <th>Time</th>
                <th>Capacity</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 50 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
             foreach (var item in events)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                 foreach (var user in users)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                     if (user.Id == item.Leader)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                        ");
            __builder.OpenElement(23, "tr");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                        () => Show(item.EventId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 57 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                 item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 58 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                 user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, "  ");
            __builder.AddContent(32, 
#nullable restore
#line 58 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                                  user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 59 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                 item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 60 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                 item.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 61 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                 item.Time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 62 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                 item.Capacity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "hidden");
            __builder.AddAttribute(48, "plachehold", 
#nullable restore
#line 63 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                                              eventId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                                                               item.EventId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.EventId = __value, item.EventId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 65 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 70 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 73 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
 if (events != null && mode == MODE.EditDelete) // Update & Delete form
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "    ");
            __builder.AddMarkupContent(58, "<label>EventName: </label>\r\n    <br>\r\n    ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "plachehold", "Name");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                     name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(64, "<label>Leader: </label>\r\n    <br>\r\n    ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "plachehold", "Leader");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                       leader

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => leader = __value, leader));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(70, "<label>Description: </label>\r\n    <br>\r\n    ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "plachehold", "Details");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                        description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => description = __value, description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(76, "<label>Date: </label>\r\n    <br>\r\n    ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "plachehold", "Date");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                     date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date = __value, date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(82, "<label>Time: </label>\r\n    <br>\r\n    ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "plachehold", "Time");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                     time

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => time = __value, time));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(88, "<label>Capacity: </label>\r\n    <br>\r\n    ");
            __builder.OpenElement(89, "input");
            __builder.AddAttribute(90, "plachehold", "Details");
            __builder.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 97 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                                        capacity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => capacity = __value, capacity));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    <br>\r\n    ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                       Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "class", "btn btn-primary");
            __builder.AddContent(97, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.AddMarkupContent(99, "<span>&nbsp;&nbsp;&nbsp;&nbsp;</span>\r\n    ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
                       Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "class", "btn btn-danger");
            __builder.AddContent(103, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 102 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement2.razor"
           
    List<Event> events;
    List<AspNetUsers> users;
    string eventId;
    string leader;
    string Group;
    string name;
    string description;
    string date;
    string time;
    string capacity;
    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    Event activity;

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
    }

    async Task LookUp()
    {
        await JsRuntime.InvokeVoidAsync("mySearch");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService aspNetUsersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventService eventService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
