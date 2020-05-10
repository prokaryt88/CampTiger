#pragma checksum "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f516563deace37ed05305673e282c81ea82716d4"
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
#line 2 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EventManagement")]
    public partial class EventManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> Event Records</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>Create, Read, Edit, and Delete Event records.</p>\r\n");
#nullable restore
#line 7 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
 if (events == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em> Loading...</em></p>\r\n");
#nullable restore
#line 10 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                   Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "btn btn-success");
            __builder.AddContent(6, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-hover");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, @"<thead>
        <tr>
            <th>ID</th>
            <th>GrID</th>
            <th>Name</th>
            <th>Leader</th>
            <th>Details</th>
            <th>Date</th>
            <th>Time</th>
            <th>Capacity</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 28 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         foreach (var item in events)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                () => Show(item.EventId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         item.EventId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         item.Group

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 34 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         item.Leader

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 35 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 36 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         item.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 37 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         item.Time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
         item.Capacity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 40 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 43 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
 if (events != null && mode == MODE.Add)
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<label>EventId: </label>\r\n<br>\r\n");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "plachehold", "Event ID");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                     eventId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eventId = __value, eventId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n<br>\r\n");
            __builder.AddMarkupContent(51, "<label>Group: </label>\r\n<br>\r\n");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "plachehold", "Group ID");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                     Group

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Group = __value, Group));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n<br>\r\n");
            __builder.AddMarkupContent(57, "<label>EventName: </label>\r\n<br>\r\n");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "plachehold", "Name");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                 name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n<br>\r\n");
            __builder.AddMarkupContent(63, "<label>Leader: </label>\r\n<br>\r\n");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "plachehold", "Leader");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                   leader

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => leader = __value, leader));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n<br>\r\n");
            __builder.AddMarkupContent(69, "<label>Description: </label>\r\n<br>\r\n");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "plachehold", "Details");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                    description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => description = __value, description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n<br>\r\n");
            __builder.AddMarkupContent(75, "<label>Location: </label>\r\n<br>\r\n");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "plachehold", "Date");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                 date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date = __value, date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n<br>\r\n");
            __builder.AddMarkupContent(81, "<label>Time: </label>\r\n<br>\r\n");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "plachehold", "Time");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                 time

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => time = __value, time));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n<br>\r\n");
            __builder.AddMarkupContent(87, "<label>Capacity: </label>\r\n<br>\r\n");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "plachehold", "Details");
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                    capacity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => capacity = __value, capacity));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n<br>\r\n");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                   Insert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "class", "btn btn-warning");
            __builder.AddContent(96, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 81 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
 if (events != null && mode == MODE.EditDelete) // Update & Delete form
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "input");
            __builder.AddAttribute(99, "type", "hidden");
            __builder.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                             eventId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eventId = __value, eventId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n<br>\r\n");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "type", "hidden");
            __builder.AddAttribute(105, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                             Group

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Group = __value, Group));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n<br>\r\n");
            __builder.AddMarkupContent(108, "<label>EventName: </label>\r\n<br>\r\n");
            __builder.OpenElement(109, "input");
            __builder.AddAttribute(110, "plachehold", "Name");
            __builder.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                 name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n<br>\r\n");
            __builder.AddMarkupContent(114, "<label>Leader: </label>\r\n<br>\r\n");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "plachehold", "Leader");
            __builder.AddAttribute(117, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                   leader

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => leader = __value, leader));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n<br>\r\n");
            __builder.AddMarkupContent(120, "<label>Description: </label>\r\n<br>\r\n");
            __builder.OpenElement(121, "input");
            __builder.AddAttribute(122, "plachehold", "Details");
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 100 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                    description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => description = __value, description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n<br>\r\n");
            __builder.AddMarkupContent(126, "<label>Location: </label>\r\n<br>\r\n");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "plachehold", "Date");
            __builder.AddAttribute(129, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                 date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date = __value, date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n<br>\r\n");
            __builder.AddMarkupContent(132, "<label>Time: </label>\r\n<br>\r\n");
            __builder.OpenElement(133, "input");
            __builder.AddAttribute(134, "plachehold", "Time");
            __builder.AddAttribute(135, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 108 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                 time

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => time = __value, time));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n<br>\r\n");
            __builder.AddMarkupContent(138, "<label>Capacity: </label>\r\n<br>\r\n");
            __builder.OpenElement(139, "input");
            __builder.AddAttribute(140, "plachehold", "Details");
            __builder.AddAttribute(141, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 112 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                                    capacity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => capacity = __value, capacity));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n<br>\r\n");
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                   Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(146, "class", "btn btn-primary");
            __builder.AddContent(147, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n");
            __builder.AddMarkupContent(149, "<span>&nbsp;&nbsp;&nbsp;&nbsp;</span>\r\n");
            __builder.OpenElement(150, "button");
            __builder.AddAttribute(151, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 116 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
                   Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "class", "btn btn-danger");
            __builder.AddContent(153, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
#nullable restore
#line 117 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\EventManagement.razor"
           
    List<Event> events;
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
    protected async Task Insert()
    {
        Event e = new Event()
        {
            EventId = eventId,
            Group = Group,
            Name = name,
            Leader = leader,
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
        ClearFields();
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
            Group = Group,
            Name = name,
            Leader = leader,
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
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventService eventService { get; set; }
    }
}
#pragma warning restore 1591
