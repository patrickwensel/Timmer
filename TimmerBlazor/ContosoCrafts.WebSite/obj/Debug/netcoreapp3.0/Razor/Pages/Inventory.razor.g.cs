#pragma checksum "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57bf451028803a833488a54dccf198d6b9c75bb4"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.WebSite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using ContosoCrafts.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\_Imports.razor"
using ContosoCrafts.WebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
using ContosoCrafts.WebSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
using ContosoCrafts.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory")]
    public partial class Inventory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h1>Detail Search</h1>\r\n    ");
            __builder.OpenElement(4, "form");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<label for=\"SideSearchLabel\">Category</label>\r\n            ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "id", "StudentGender");
            __builder.AddAttribute(13, "name", "StudentGender");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
                                                                                        product.Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Category = __value, product.Category));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "option");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, "Tractors");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "option");
            __builder.AddContent(23, "Skid Steer");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "option");
            __builder.AddMarkupContent(26, "Hay & Forage");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, "<label for=\"SideSearchLabel\">Make</label>\r\n            ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "placeholder", "Make");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
                                                           product.Maker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Maker = __value, product.Maker));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddMarkupContent(45, "<label for=\"SideSearchLabel\">Model</label>\r\n            ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "placeholder", "Model");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
                                                           product.Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Model = __value, product.Model));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.AddMarkupContent(57, "<label for=\"SideSearchLabel\">New Or Used</label>\r\n            ");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "id", "StudentGender");
            __builder.AddAttribute(61, "name", "StudentGender");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
                                                                   product.UsedType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.UsedType = __value, product.UsedType));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "option");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "option");
            __builder.AddContent(68, "New");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "option");
            __builder.AddContent(71, "Used");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col");
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.AddMarkupContent(78, "<label for=\"SideSearchLabel\">Location</label>\r\n            ");
            __builder.OpenElement(79, "select");
            __builder.AddAttribute(80, "class", "form-control");
            __builder.AddAttribute(81, "id", "StudentGender");
            __builder.AddAttribute(82, "name", "StudentGender");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
                                                                   product.Location

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Location = __value, product.Location));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "option");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "option");
            __builder.AddContent(89, "Aitkin");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "option");
            __builder.AddContent(92, "Milaca");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col");
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.AddMarkupContent(99, "<label for=\"SideSearchLabel\">Stock #</label>\r\n            ");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "type", "text");
            __builder.AddAttribute(102, "class", "form-control");
            __builder.AddAttribute(103, "placeholder", "Stock #");
            __builder.AddAttribute(104, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
                                                                                 product.Stock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Stock = __value, product.Stock));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.OpenElement(108, "button");
            __builder.AddAttribute(109, "type", "button");
            __builder.AddAttribute(110, "class", "btn btn-secondary btn-lg btn-block");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
                                                                                   SearchProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(112, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "content");
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.OpenComponent<ContosoCrafts.WebSite.Components.ProductList>(119);
            __builder.AddAttribute(120, "Products", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<ContosoCrafts.WebSite.Models.Product>>(
#nullable restore
#line 52 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
                                 Products

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "ProductsChanged", new System.Action<System.Collections.Generic.IList<ContosoCrafts.WebSite.Models.Product>>(__value => Products = __value));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Pages\Inventory.razor"
       
    IList<Product> Products = null;
    Product product = new Product();

    protected override async Task OnInitializedAsync()
    {
        Products = ProductService.SearchProducts(product);
    }

    void SearchProduct()
    {
        Products = ProductService.SearchProducts(product);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591