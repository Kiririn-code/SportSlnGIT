// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SportStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/admin/Desktop/project/WEB/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Desktop/project/WEB/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/Desktop/project/WEB/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/admin/Desktop/project/WEB/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/admin/Desktop/project/WEB/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/admin/Desktop/project/WEB/SportSln/SportsStore/Pages/Admin/_Imports.razor"
using SportStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/Users/admin/Desktop/project/WEB/SportSln/SportsStore/Pages/Admin/Details.razor"
      
    [Inject]
    public IStoreRepository Repository { get; set; }
    [Parameter]
    public long Id { get; set; }
    public Product Product { get; set; }

    protected override void OnParametersSet()
    {
        Product = Repository.Products.FirstOrDefault(p => p.ProductID == Id);
    }

    public string EditUrl =>$"/admin/products/edit/{Product.ProductID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
