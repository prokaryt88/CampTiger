#pragma checksum "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f322804aa60138620dd0d9d45146099bba76fbd"
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
#line 2 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
using CampTiger.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
using CampTiger.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UseInfo")]
    public partial class UserInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>UserInfo</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
 if (Users != null && mode == MODE.Add) // Insert form
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<label> First Name:</label>\r\n    <br>\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "placeholder", "First Name");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
                                            firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(8, "<label> Last Name:</label>\r\n    <br>\r\n    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "placeholder", "Name");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
                                      lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(14, "<label> Address:</label>\r\n    <br>\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "placeholder", "Address");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
                                         address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => address = __value, address));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(20, "<label> State:</label>\r\n    <br>\r\n    ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "placeholder", "State");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
                                       state

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => state = __value, state));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(26, "<label> Zip:</label>\r\n    <br>\r\n    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "placeholder", "Zip");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
                                     zip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => zip = __value, zip));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(32, "<label> Phone:</label>\r\n    <br>\r\n    ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "placeholder", "Phone");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
                                       phone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => phone = __value, phone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    <br>\r\n    ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
                       Insert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-warning");
            __builder.AddContent(41, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 34 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Alex\Documents\GitHub\CampTiger\Pages\UserInfo.razor"
       
    List<AspNetUsers> Users;
    string firstName;
    string lastName;
    string address;
    string state;
    string zip;
    string phone;
    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    AspNetUsers User;

    protected async Task Insert()
    {

        AspNetUsers u = new AspNetUsers()
        {
            FirstName = firstName,
            LastName = lastName,
            Address = address,
            State = state,
            Zip = zip,
            Phone = phone
        };

        await userService.InsertAspNetUsersAsync(u);

        mode = MODE.None;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersService userService { get; set; }
    }
}
#pragma warning restore 1591
