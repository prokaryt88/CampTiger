#pragma checksum "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a437a0d5cc0f65caca8f18292bc1d7e3e89d546c"
// <auto-generated/>
#pragma warning disable 1591
namespace CampTiger.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>CampTiger</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "Roles", "normal, groupleader");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(31, "\n            ");
                __builder2.OpenElement(32, "li");
                __builder2.AddAttribute(33, "class", "nav-item px-3");
                __builder2.AddMarkupContent(34, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
                __builder2.AddAttribute(36, "class", "nav-link");
                __builder2.AddAttribute(37, "href", "UserInfo");
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "\n                    <span class=\"oi oi-person\" aria-hidden=\"true\"></span> Edit My Info\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(43);
            __builder.AddAttribute(44, "Roles", "normal");
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(46, "\n            ");
                __builder2.OpenElement(47, "li");
                __builder2.AddAttribute(48, "class", "nav-item px-3");
                __builder2.AddMarkupContent(49, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
                __builder2.AddAttribute(51, "class", "nav-link");
                __builder2.AddAttribute(52, "href", "GroupSignUp");
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(54, "\n                    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Group Sign Up\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n            ");
                __builder2.OpenElement(57, "li");
                __builder2.AddAttribute(58, "class", "nav-item px-3");
                __builder2.AddMarkupContent(59, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
                __builder2.AddAttribute(61, "class", "nav-link");
                __builder2.AddAttribute(62, "href", "MyGroups");
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "\n                    <span class=\"oi oi-people\" aria-hidden=\"true\"></span> Your Groups\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n            ");
                __builder2.OpenElement(67, "li");
                __builder2.AddAttribute(68, "class", "nav-item px-3");
                __builder2.AddMarkupContent(69, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(70);
                __builder2.AddAttribute(71, "class", "nav-link");
                __builder2.AddAttribute(72, "href", "EventSignUp");
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(74, "\n                    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Event Sign Up\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n            ");
                __builder2.OpenElement(77, "li");
                __builder2.AddAttribute(78, "class", "nav-item px-3");
                __builder2.AddMarkupContent(79, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(80);
                __builder2.AddAttribute(81, "class", "nav-link");
                __builder2.AddAttribute(82, "href", "UpcomingEvents");
                __builder2.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(84, "\n                    <span class=\"oi oi-calendar\" aria-hidden=\"true\"></span> Upcoming Events\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(87, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(88);
            __builder.AddAttribute(89, "Roles", "groupleader");
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(91, "\n            ");
                __builder2.OpenElement(92, "li");
                __builder2.AddAttribute(93, "class", "nav-item px-3");
                __builder2.AddMarkupContent(94, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(95);
                __builder2.AddAttribute(96, "class", "nav-link");
                __builder2.AddAttribute(97, "href", "EventManagement");
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(99, "\n                    <span class=\"oi oi-calendar\" aria-hidden=\"true\"></span> Event Management\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(102, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(103);
            __builder.AddAttribute(104, "Roles", "admin, groupleader");
            __builder.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(106, "\n            ");
                __builder2.OpenElement(107, "li");
                __builder2.AddAttribute(108, "class", "nav-item px-3");
                __builder2.AddMarkupContent(109, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(110);
                __builder2.AddAttribute(111, "class", "nav-link");
                __builder2.AddAttribute(112, "href", "RequestManagement");
                __builder2.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(114, "\n                    <span class=\"oi oi-check\" aria-hidden=\"true\"></span> Event Requests\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(117, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(118);
            __builder.AddAttribute(119, "Roles", "admin");
            __builder.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(121, "\n            ");
                __builder2.OpenElement(122, "li");
                __builder2.AddAttribute(123, "class", "nav-item px-3");
                __builder2.AddMarkupContent(124, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(125);
                __builder2.AddAttribute(126, "class", "nav-link");
                __builder2.AddAttribute(127, "href", "EventManagement2");
                __builder2.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(129, "\n                    <span class=\"oi oi-calendar\" aria-hidden=\"true\"></span> Event Management\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\n            ");
                __builder2.OpenElement(132, "li");
                __builder2.AddAttribute(133, "class", "nav-item px-3");
                __builder2.AddMarkupContent(134, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(135);
                __builder2.AddAttribute(136, "class", "nav-link");
                __builder2.AddAttribute(137, "href", "UserManagement");
                __builder2.AddAttribute(138, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(139, "\n                    <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> User Management\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(140, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\n            ");
                __builder2.OpenElement(142, "li");
                __builder2.AddAttribute(143, "class", "nav-item px-3");
                __builder2.AddMarkupContent(144, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(145);
                __builder2.AddAttribute(146, "class", "nav-link");
                __builder2.AddAttribute(147, "href", "GroupManagement");
                __builder2.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(149, "\n                    <span class=\"oi oi-people\" aria-hidden=\"true\"></span> Group Management\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(150, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(152, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\jkafk\Downloads\CampTiger-master (7)\CampTiger-master\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
