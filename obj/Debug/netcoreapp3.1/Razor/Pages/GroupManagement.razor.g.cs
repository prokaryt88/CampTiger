#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (8)\CampTiger-master\Pages\GroupManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e654f508660406f9a82b9b1d89ce265fc8f196df"
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
#line 2 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroupManagement")]
    public partial class GroupManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> Group Management </h1>\n");
            __builder.AddMarkupContent(1, "<p> Create, Read, Edit, and Delete Group records.</p>\n\n");
#nullable restore
#line 13 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
 if (groups == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em> Loading...</em></p>\n");
#nullable restore
#line 16 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                       Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddContent(8, "Add Group");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-hover");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddMarkupContent(13, "<thead>\n            <tr>\n                <th>ID</th>\n                <th>Leader</th>\n                <th>Name</th>\n                <th>Description</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 30 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
             foreach (var item in groups)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                 foreach (var user in users)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                     if (user.Id == item.Leader)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                        ");
            __builder.OpenElement(17, "tr");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                        () => Show(item.GroupId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "\n                            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 37 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                 item.GroupId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                 user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, "  ");
            __builder.AddContent(26, 
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                                  user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 39 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                 item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 40 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                 item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 42 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 47 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
 if (groups != null && mode == MODE.Add) // Insert form
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.AddMarkupContent(39, "<label> Leader:</label>\n    <br>\n    ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "placeholder", "Leader");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                        leader

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => leader = __value, leader));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n    <br>\n    ");
            __builder.AddMarkupContent(45, "<label> Name:</label>\n    <br>\n    ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "placeholder", "Name");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                      name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n    <br>\n    ");
            __builder.AddMarkupContent(51, "<label> Description:</label>\n    <br>\n    ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "placeholder", "Description");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                             description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => description = __value, description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n    <br>\n    ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                       Insert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "class", "btn btn-warning");
            __builder.AddContent(60, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n");
#nullable restore
#line 63 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
 if (groups != null && mode == MODE.EditDelete) // Update & Delete form
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "    ");
            __builder.OpenElement(63, "label");
            __builder.AddContent(64, " Group ID: ");
            __builder.AddContent(65, 
#nullable restore
#line 66 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                       groupId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n    <br>\n    ");
            __builder.AddMarkupContent(67, "<label> Leader:</label>\n    <br>\n    ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "placeholder", "Leader");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                        leader

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => leader = __value, leader));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n    <br>\n    ");
            __builder.AddMarkupContent(73, "<label> Name:</label>\n    <br>\n    ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "placeholder", "Name");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                      name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n    <br>\n    ");
            __builder.AddMarkupContent(79, "<label> Description:</label>\n    <br>\n    ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "placeholder", "Description");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                                             description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => description = __value, description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n    <br>\n    ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                       Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "class", "btn btn-primary");
            __builder.AddContent(88, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n    ");
            __builder.AddMarkupContent(90, "<span>&nbsp;&nbsp;&nbsp;&nbsp;</span>\n    ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
                       Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "class", "btn btn-danger");
            __builder.AddContent(94, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n");
#nullable restore
#line 83 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
       

    List<Group> groups;
    List<AspNetUsers> users;
    string groupId;
    string leader;
    string name;
    string description;
    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    Group group;

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        groups = await groupService.GetGroupAsync();
        users = await aspNetUsersService.GetAspNetUsersAsync();
    }

    protected async Task Insert()
    {
        groupId = Guid.NewGuid().ToString();
        Group g = new Group()
        {
            GroupId = groupId,
            Leader = leader,
            Name = name,
            Description = description
        };

        await groupService.InsertGroupAsync(g);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected void ClearFields()
    {
        groupId = string.Empty;
        leader = string.Empty;
        name = string.Empty;
        description = string.Empty;
    }

    protected void Add()
    {
        ClearFields();
        mode = MODE.Add;
    }

    protected async Task Update()
    {

        Group g = new Group()
        {
            GroupId = groupId,
            Leader = leader,
            Name = name,
            Description = description
        };

        await groupService.UpdateGroupAsync(groupId, g);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Delete()
    {
        await groupService.DeleteGroupAsync(groupId);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Show(string id)
    {
        group = await groupService.GetGroupByIdAsync(id);
        groupId = group.GroupId;
        leader = group.Leader;
        description = group.Description;
        name = group.Name;
        mode = MODE.EditDelete;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService aspNetUsersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GroupService groupService { get; set; }
    }
}
#pragma warning restore 1591
