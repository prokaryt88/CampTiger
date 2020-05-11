#pragma checksum "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85c9a4767a2b37a4bfce44ae766ae0a26ee4fe5c"
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
           [Authorize(Roles = "admin, groupleader")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroupManagement")]
    public partial class GroupManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\GroupManagement.razor"
       

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
