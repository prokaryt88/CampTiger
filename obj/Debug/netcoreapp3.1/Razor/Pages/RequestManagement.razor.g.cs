#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\RequestManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1646567d2f8d5ec1416ba05efc01b1be15b6a026"
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
            __builder.AddMarkupContent(0, "<h3>Request Management</h3>\r\n");
            __builder.AddMarkupContent(1, "<p>Accept or deny member event join requests.</p>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 22 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-hover");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th> </th>\r\n                <th> </th>\r\n                <th> </th>\r\n                <th> </th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "Roles", "groupleader");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n");
#nullable restore
#line 36 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                 foreach (var user in users)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(15, "                    ");
                __builder2.OpenElement(16, "tr");
                __builder2.AddContent(17, 
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                         user.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(18, "  ");
                __builder2.AddContent(19, 
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                          user.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n");
#nullable restore
#line 39 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                     foreach (var activity in records)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(21, "                        ");
                __builder2.OpenElement(22, "tr");
                __builder2.AddMarkupContent(23, "\r\n");
#nullable restore
#line 42 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                             foreach (var group in groups)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                 if (activity.UserId == user.Id & activity.Approved == false & group.Leader == userId)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                     foreach (var item in events)
                                    {
                                        if (activity.EventId == item.EventId & item.Group == group.GroupId)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "                                            ");
                __builder2.AddMarkupContent(25, "<td>Event and Details:</td>\r\n                                            ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 51 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                                 item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                                            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, "Date: ");
                __builder2.AddContent(31, 
#nullable restore
#line 52 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                                       item.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                            ");
                __builder2.OpenElement(33, "td");
                __builder2.AddContent(34, "Time: ");
                __builder2.AddContent(35, 
#nullable restore
#line 53 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                                       item.Time

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                                            ");
                __builder2.OpenElement(37, "td");
                __builder2.AddMarkupContent(38, "\r\n                                                ");
                __builder2.OpenElement(39, "button");
                __builder2.AddAttribute(40, "class", "btn btn-primary");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                                                                          (() => AcceptRequest(user, item))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(42, "\r\n                                                    Accept\r\n                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                                            ");
                __builder2.AddMarkupContent(45, "<td> &nbsp;</td>\r\n");
#nullable restore
#line 60 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                     

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(46, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
#nullable restore
#line 68 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(50);
            __builder.AddAttribute(51, "Roles", "admin");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n");
#nullable restore
#line 72 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                 foreach (var user in users)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, "                    ");
                __builder2.OpenElement(55, "tr");
                __builder2.AddContent(56, 
#nullable restore
#line 74 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                         user.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(57, "  ");
                __builder2.AddContent(58, 
#nullable restore
#line 74 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                          user.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n");
#nullable restore
#line 75 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                     foreach (var activity in records)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(60, "                        ");
                __builder2.OpenElement(61, "tr");
                __builder2.AddMarkupContent(62, "\r\n");
#nullable restore
#line 78 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                             if (activity.UserId == user.Id & activity.Approved == false)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                 foreach (var item in events)
                                {
                                    if (activity.EventId == item.EventId)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(63, "                                        ");
                __builder2.AddMarkupContent(64, "<td>Event and Details:</td>\r\n                                        ");
                __builder2.OpenElement(65, "td");
                __builder2.AddContent(66, 
#nullable restore
#line 85 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                             item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                        ");
                __builder2.OpenElement(68, "td");
                __builder2.AddContent(69, "Date: ");
                __builder2.AddContent(70, 
#nullable restore
#line 86 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                                   item.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                                        ");
                __builder2.OpenElement(72, "td");
                __builder2.AddContent(73, "Time: ");
                __builder2.AddContent(74, 
#nullable restore
#line 87 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                                   item.Time

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                        ");
                __builder2.OpenElement(76, "td");
                __builder2.AddMarkupContent(77, "\r\n                                            ");
                __builder2.OpenElement(78, "button");
                __builder2.AddAttribute(79, "class", "btn btn-primary");
                __builder2.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                                                                      (() => AcceptRequest(user, item))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(81, "\r\n                                                Accept\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                        ");
                __builder2.AddMarkupContent(84, "<td> &nbsp;</td>\r\n");
#nullable restore
#line 94 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                                 

                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n");
#nullable restore
#line 100 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(87, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 105 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\RequestManagement.razor"
}

#line default
#line hidden
#nullable disable
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
