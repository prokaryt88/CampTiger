#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1449dc8752d79a1e4c407a6787dd1155a03b5d9b"
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
#line 1 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using CampTiger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\_Imports.razor"
using CampTiger.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
           [Authorize(Roles = "normal")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UpcomingEvents")]
    public partial class UpcomingEvents : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Users</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Your Upcoming Approved Events and Pending Requests</p>\n\n");
#nullable restore
#line 19 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 22 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
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
            __builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Your upcoming events</th>\n                <th>Date</th>\n                <th>Time</th>\n                <th>Leave</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 35 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
             foreach (var activity in records)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                 if (activity.Approved == true & activity.UserId == userId)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                     foreach (var item in events)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                         if (activity.EventId == item.EventId)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 44 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 45 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                                     item.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 46 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                                     item.Time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                                ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\n                                    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                                                                              (() => Delete(item.EventId, userId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Leave");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "                             \n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
#nullable restore
#line 51 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                     

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n    ");
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "class", "table table-hover");
            __builder.AddMarkupContent(37, "\n        ");
            __builder.AddMarkupContent(38, "<thead>\n            <tr>\r\n                <th>Pending join requests</th>\r\n                <th>Date</th>\r\n                <th>Time</th>\r\n                <th>Leave</th>\r\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(39, "tbody");
            __builder.AddMarkupContent(40, "\n");
#nullable restore
#line 68 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
             foreach (var activity in records)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                 if (activity.Approved == false & activity.UserId == userId)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                     foreach (var item in events)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                         if (activity.EventId == item.EventId)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                            ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\n                                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 77 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 78 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                                     item.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 79 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                                     item.Time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                                ");
            __builder.OpenElement(53, "td");
            __builder.AddMarkupContent(54, "\n                                    ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                                                                              (() => Delete(item.EventId, userId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Leave");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "                             \n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n");
#nullable restore
#line 84 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                     

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n");
#nullable restore
#line 91 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Pages\UpcomingEvents.razor"
            
    List<AspNetUsers> users;
    List<Event> events;
    List<UserEvent> records;
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
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var currentUser = await UserManager.GetUserAsync(user);
        userId = currentUser.Id;
    }

    protected async Task Delete(string eID, string uId)
    {
        await userEventService.DeleteUserEventAsync(eID, uId);
        await load();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserEventService userEventService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventService eventService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
