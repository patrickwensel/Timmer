#pragma checksum "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e77541a87d7e5f37e14cd9611c0fdfd86681f731"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.WebSite.Components
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
#line 1 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 6 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
     if (Products != null && Products.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
         foreach (var product in Products)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "            ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\r\n                ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12 mt-3");
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.AddMarkupContent(15, "\r\n                            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-horizontal");
            __builder.AddMarkupContent(18, "\r\n                                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "img-square-wrapper col-md-12");
            __builder.AddMarkupContent(21, "\r\n                                    ");
            __builder.OpenElement(22, "h4");
            __builder.AddAttribute(23, "class", "card-title");
            __builder.AddContent(24, 
#nullable restore
#line 16 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                            product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n                                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.AddMarkupContent(28, "\r\n                                        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-md-3");
            __builder.AddMarkupContent(31, "\r\n                                            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-img");
            __builder.AddAttribute(34, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 20 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n                                        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-9");
            __builder.AddMarkupContent(39, "\r\n                                            ");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "class", "card-text");
            __builder.AddContent(42, "Category : ");
            __builder.AddContent(43, 
#nullable restore
#line 24 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                             product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                            ");
            __builder.OpenElement(45, "p");
            __builder.AddAttribute(46, "class", "card-text");
            __builder.AddContent(47, "Maker : ");
            __builder.AddContent(48, 
#nullable restore
#line 25 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                          product.Maker

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                            ");
            __builder.OpenElement(50, "p");
            __builder.AddAttribute(51, "class", "card-text");
            __builder.AddContent(52, "Model : ");
            __builder.AddContent(53, 
#nullable restore
#line 26 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                          product.Model

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                            ");
            __builder.OpenElement(55, "p");
            __builder.AddAttribute(56, "class", "card-text");
            __builder.AddContent(57, "Type : ");
            __builder.AddContent(58, 
#nullable restore
#line 27 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                         product.UsedType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                                            ");
            __builder.OpenElement(60, "p");
            __builder.AddAttribute(61, "class", "card-text");
            __builder.AddContent(62, "Location : ");
            __builder.AddContent(63, 
#nullable restore
#line 28 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                             product.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                            ");
            __builder.OpenElement(65, "p");
            __builder.AddAttribute(66, "class", "card-text");
            __builder.AddContent(67, "Stock : ");
            __builder.AddContent(68, 
#nullable restore
#line 29 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                          product.Stock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n                                    ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "card-body");
            __builder.AddMarkupContent(74, "\r\n                                        ");
            __builder.OpenElement(75, "small");
            __builder.AddAttribute(76, "class", "text-muted");
            __builder.AddMarkupContent(77, "\r\n                                            ");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "class", "btn btn-dark");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                                   (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "data-toggle", "modal");
            __builder.AddAttribute(82, "data-target", "#productModal");
            __builder.AddAttribute(83, "classs", "btn btn-primary");
            __builder.AddMarkupContent(84, "\r\n                                                More Info\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                                    ");
            __builder.AddMarkupContent(88, "<div class=\"card-footer\">\r\n                                        <small class=\"text-muted\">Last updated 3 mins ago</small>\r\n                                    </div>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 50 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "        ");
            __builder.AddMarkupContent(96, "<center>\r\n            <h4 class=\"card-title pt-3\">No Product Found</h4>\r\n        </center>\r\n");
#nullable restore
#line 57 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n");
#nullable restore
#line 62 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "modal fade");
            __builder.AddAttribute(101, "id", "productModal");
            __builder.AddAttribute(102, "tabindex", "-1");
            __builder.AddAttribute(103, "role", "dialog");
            __builder.AddAttribute(104, "aria-labelledby", "productTitle");
            __builder.AddAttribute(105, "aria-hidden", "true");
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "modal-dialog modal-xl modal-dialog-centered");
            __builder.AddAttribute(109, "role", "document");
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "modal-content");
            __builder.AddMarkupContent(113, "\r\n                ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "modal-header");
            __builder.AddMarkupContent(116, "\r\n                    ");
            __builder.OpenElement(117, "h5");
            __builder.AddAttribute(118, "class", "modal-title");
            __builder.AddAttribute(119, "id", "productTitle");
            __builder.AddContent(120, 
#nullable restore
#line 68 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.AddMarkupContent(122, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "modal-body");
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "card");
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "card-img");
            __builder.AddAttribute(132, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 75 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(133, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                        ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "card-body");
            __builder.AddMarkupContent(137, "\r\n                            ");
            __builder.OpenElement(138, "p");
            __builder.AddAttribute(139, "class", "card-text");
            __builder.AddContent(140, 
#nullable restore
#line 78 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                  selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                            ");
            __builder.OpenElement(142, "p");
            __builder.AddAttribute(143, "class", "card-text");
            __builder.AddContent(144, 
#nullable restore
#line 79 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                            ");
            __builder.OpenElement(146, "p");
            __builder.AddAttribute(147, "class", "card-text");
            __builder.AddContent(148, "Category : ");
            __builder.AddContent(149, 
#nullable restore
#line 80 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                             selectedProduct.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                            ");
            __builder.OpenElement(151, "p");
            __builder.AddAttribute(152, "class", "card-text");
            __builder.AddContent(153, "Maker : ");
            __builder.AddContent(154, 
#nullable restore
#line 81 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                          selectedProduct.Maker

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                            ");
            __builder.OpenElement(156, "p");
            __builder.AddAttribute(157, "class", "card-text");
            __builder.AddContent(158, "Model : ");
            __builder.AddContent(159, 
#nullable restore
#line 82 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                          selectedProduct.Model

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                            ");
            __builder.OpenElement(161, "p");
            __builder.AddAttribute(162, "class", "card-text");
            __builder.AddContent(163, "Type : ");
            __builder.AddContent(164, 
#nullable restore
#line 83 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                         selectedProduct.UsedType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                            ");
            __builder.OpenElement(166, "p");
            __builder.AddAttribute(167, "class", "card-text");
            __builder.AddContent(168, "Location : ");
            __builder.AddContent(169, 
#nullable restore
#line 84 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                             selectedProduct.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                            ");
            __builder.OpenElement(171, "p");
            __builder.AddAttribute(172, "class", "card-text");
            __builder.AddContent(173, "Stock : ");
            __builder.AddContent(174, 
#nullable restore
#line 85 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                          selectedProduct.Stock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                ");
            __builder.AddMarkupContent(179, "<div class=\"modal-footer\">\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n");
#nullable restore
#line 94 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "E:\Project\Contos\New\ContosoCrafts.WebSite\ContosoCrafts.WebSite\Components\ProductList.razor"
       

    [Parameter]
    public IList<Product> Products { get; set; }

    [Parameter]
    public Action<IList<Product>> ProductsChanged { get; set; }


    Product selectedProduct;
    string selectedProductId;

    int currentRating = 0;
    int voteCount = 0;
    string votelabel;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    void GetCurrentRating()
    {
        if (selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        {
            voteCount = selectedProduct.Ratings != null ? selectedProduct.Ratings.Count() : 0;
            votelabel = voteCount > 1 ? "Votes" : "Vote";

            if (voteCount > 0 && selectedProduct.Ratings != null)
            {
                currentRating = selectedProduct.Ratings.Sum() / voteCount;
            }
            else
            {
                currentRating = 0;
            }
        }
        System.Console.WriteLine($"Current rating for {selectedProduct.Id}:{currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Current rating for {selectedProduct.Id}:{rating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591