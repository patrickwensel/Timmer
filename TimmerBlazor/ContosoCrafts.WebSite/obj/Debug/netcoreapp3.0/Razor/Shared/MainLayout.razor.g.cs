#pragma checksum "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f99d575b498d6702c17d003f7016aafc0c7eca"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.WebSite.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using ContosoCrafts.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\_Imports.razor"
using ContosoCrafts.WebSite.Shared;

#line default
#line hidden
#nullable disable
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ContosoCrafts.WebSite.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "main");
            __builder.AddAttribute(6, "role", "main");
            __builder.AddAttribute(7, "class", "pb-3");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
            __builder.OpenElement(13, "footer");
            __builder.AddAttribute(14, "class", "page-footer font-small special-color-dark pt-4");
            __builder.AddMarkupContent(15, "\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(16, @"<div class=""container"">

        
        <ul class=""list-unstyled list-inline text-center"">
            <li class=""list-inline-item"">
                <i class=""fab fa-facebook""></i>
            </li>
            <li class=""list-inline-item"">
                <a class=""btn-floating btn-tw mx-1"">
                    <i class=""fab fa-twitter""> </i>
                </a>
            </li>
            <li class=""list-inline-item"">
                <a class=""btn-floating btn-gplus mx-1"">
                    <i class=""fab fa-google-plus-g""> </i>
                </a>
            </li>
            <li class=""list-inline-item"">
                <a class=""btn-floating btn-li mx-1"">
                    <i class=""fab fa-linkedin-in""> </i>
                </a>
            </li>
        </ul>
        

    </div>
    
    
    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "footer-copyright text-center py-3");
            __builder.AddMarkupContent(19, "\r\n        © ");
            __builder.AddContent(20, 
#nullable restore
#line 44 "C:\Users\pwens\source\repos\Timmer\TimmerBlazor\ContosoCrafts.WebSite\Shared\MainLayout.razor"
           System.DateTime.Now.Year

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, " Copyright:\r\n        ");
            __builder.AddMarkupContent(22, "<p>Timmer Implment, Inc.</p>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    \r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
