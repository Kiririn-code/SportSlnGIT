#pragma checksum "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2247ed95d933796a210d76a0502ee98053032a21"
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
#line 1 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\_Imports.razor"
using SportStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/edit/{id:long}")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/create")]
    public partial class Editor : OwningComponentBase<IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    div.validation-massage{color:rgb(220,53,69); font-weight: 500}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 10 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-center" + " p-1" + " text-white");
            __builder.AddContent(3, " ");
#nullable restore
#line 10 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
__builder.AddContent(4, TitleText);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, " a product");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 12 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                 Product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                         SaveProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n");
#nullable restore
#line 14 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
     if (Product.ProductID != 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, "        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.AddMarkupContent(18, "<label>ID</label>\r\n            ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "disabled", true);
                __builder2.AddAttribute(22, "value", 
#nullable restore
#line 18 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                                         Product.ProductID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n");
#nullable restore
#line 20 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(25, "    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.AddMarkupContent(29, "<label>Name</label>\r\n        ");
                global::__Blazor.SportStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 23 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 24 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Name = __value, Product.Name))));
                __builder2.AddAttribute(37, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.AddMarkupContent(43, "<label>Description</label>\r\n        ");
                global::__Blazor.SportStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 44, 45, 
#nullable restore
#line 28 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 29 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Description = __value, Product.Description))));
                __builder2.AddAttribute(51, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.AddMarkupContent(57, "<label>Category</label>\r\n        ");
                global::__Blazor.SportStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 58, 59, 
#nullable restore
#line 33 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 34 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Category = __value, Product.Category))));
                __builder2.AddAttribute(65, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group");
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.AddMarkupContent(71, "<label>Price</label>\r\n        ");
                global::__Blazor.SportStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 72, 73, 
#nullable restore
#line 38 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(74, "\r\n        ");
                global::__Blazor.SportStore.Pages.Admin.Editor.TypeInference.CreateInputNumber_4(__builder2, 75, 76, "form-control", 77, 
#nullable restore
#line 39 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                                       Product.Price

#line default
#line hidden
#nullable disable
                , 78, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Price = __value, Product.Price)), 79, () => Product.Price);
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n    ");
                __builder2.OpenElement(82, "button");
                __builder2.AddAttribute(83, "type", "submit");
                __builder2.AddAttribute(84, "class", "btn" + " btn-" + (
#nullable restore
#line 42 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(85, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(87);
                __builder2.AddAttribute(88, "class", "btn btn-secondary");
                __builder2.AddAttribute(89, "href", "/admin/products");
                __builder2.AddAttribute(90, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(91, "Back");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\yaale\Desktop\Project\WEB\SportSlnGIT\SportsStore\Pages\Admin\Editor.razor"
 
    public IStoreRepository Repository => Service;

    [Parameter]
    public long Id { get; set; }
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    public Product Product { get; set; } = new Product();

    protected override void OnParametersSet()
    {
        if(Id != 0)
        {
            Product = Repository.Products.FirstOrDefault(p => p.ProductID == Id);
        }
    }

    public void SaveProduct()
    {
        if(Id == 0)
        {
            Repository.CreateProduct(Product);
        }
        else
        {
            Repository.SaveProduct(Product);
        }

        NavigationManager.NavigateTo("/admin/products");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Cerate" : "Edit";


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SportStore.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
