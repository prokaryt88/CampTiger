#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f24cf327a99a3c4bee3e49e20c07ed8d1be2f17b"
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
#line 2 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
           [Authorize(Roles = "normal")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EventSignUp")]
    public partial class EventSignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> Event Sign Up</h1>\n");
            __builder.AddMarkupContent(1, "<p>Choose your Events</p>\n\n");
            __builder.AddMarkupContent(2, @"<style>
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
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "id", "searchKey");
            __builder.AddAttribute(6, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                                             LookUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "placeholder", "Search for events by name...");
            __builder.AddAttribute(8, "title", "Type in a name");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n<br>\n\n");
#nullable restore
#line 34 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
 if (events == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.AddMarkupContent(11, "<p><em> Loading...</em></p>\n");
#nullable restore
#line 37 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table table-hover");
            __builder.AddAttribute(15, "id", "list");
            __builder.AddMarkupContent(16, "\n        ");
            __builder.AddMarkupContent(17, @"<thead>
            <tr>
                <th>Name</th>
                <th>Description</th>
                <th>Date</th>
                <th>Time</th>
                <th>Capacity</th>
                <th>Group</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 52 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
             foreach (var group in groups)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                 foreach (var record in records)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                     foreach (var sect in events)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                         if (record.GroupId == group.GroupId & record.UserId == userId & sect.Group == group.GroupId)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\n                                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 61 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                                     sect.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 62 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                                     sect.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 63 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                                     sect.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 64 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                                     sect.Time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 65 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                                     sect.Capacity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 66 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                                     group.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                                ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\n                                    ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                                                                              (() => Insert(sect))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Sign-Up");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
#nullable restore
#line 71 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
#nullable restore
#line 78 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\EventSignUp.razor"
       

    List<Event> events;
    List<Group> groups;
    List<UserGroups> records;
    string eventId;
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
        events = await eventService.GetEventsAsync();
        groups = await groupService.GetGroupAsync();
        records = await userGroupService.GetUserGroupAsync();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var currentUser = await UserManager.GetUserAsync(user);
        userId = currentUser.Id;
    }

    protected async Task Insert(Event activity)
    {
        UserEvent g = new UserEvent()
        {
            EventId = activity.EventId,
            UserId = userId
        };
        await userEventService.InsertUserEventAsync(g);
        await load();
        mode = MODE.None;
    }

    async Task LookUp()
    {
        await JsRuntime.InvokeVoidAsync("mySearch");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserGroupService userGroupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GroupService groupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserEventService userEventService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventService eventService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
