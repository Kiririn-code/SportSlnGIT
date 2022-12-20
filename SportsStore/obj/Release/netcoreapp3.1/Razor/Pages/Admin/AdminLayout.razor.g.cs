#pragma checksum "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63de8eb18b35c8f2d29ade86b6468275c3a248a2"
// <auto-generated/>
#pragma warning disable 1591
namespace SportStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using SportStore.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""bg-info text-white p-2"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col"">
                    <span class=""navbar-brand ml-2"">SPORT STORE ADMINISTRATION</span>
                </div>
                <div class=""col-2 text-right"">
                    <a class=""btn btn-primary btn-sm"" href=""/account/logout"">LogOut</a>
                </div>
            </div>
        </div>
    </div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(12, "href", "/admin/products");
            __builder.AddAttribute(13, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(14, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 22 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/AdminLayout.razor"
                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\n                Products\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(20, "href", "/admin/orders");
            __builder.AddAttribute(21, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(22, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 28 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/AdminLayout.razor"
                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\n                Orders\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col");
            __builder.AddMarkupContent(29, "\n            ");
#nullable restore
#line 33 "/Users/admin/Desktop/project/SportSln/SportsStore/Pages/Admin/AdminLayout.razor"
__builder.AddContent(30, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
