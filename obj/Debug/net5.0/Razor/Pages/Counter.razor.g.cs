#pragma checksum "C:\Users\elimens\Desktop\Projects\ScyLab\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ee91427777d74405cd81631f6b631ae31bd283"
// <auto-generated/>
#pragma warning disable 1591
namespace ScyLab.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using ScyLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\elimens\Desktop\Projects\ScyLab\_Imports.razor"
using ScyLab.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"learn__header\">Lear More</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"acc__items\"><div class=\"accordion p-5\" id=\"accordionExample\"><div class=\"accordion-item\"><h2 class=\"accordion-header\" id=\"headingOne\"><button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\" aria-expanded=\"false\" aria-controls=\"collapseOne\">\r\n               Test Results Explained\r\n            </button></h2>\r\n        <div id=\"collapseOne\" class=\"accordion-collapse collapse\" aria-labelledby=\"headingOne\" data-bs-parent=\"#accordionExample\"><div class=\"accordion-body\">\r\n                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n            </div></div></div>\r\n    <div class=\"accordion-item mt-3\"><h2 class=\"accordion-header\" id=\"headingTwo\"><button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\" aria-expanded=\"false\" aria-controls=\"collapseTwo\">\r\n                Looking for your Text Tesults\r\n            </button></h2>\r\n        <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" aria-labelledby=\"headingTwo\" data-bs-parent=\"#accordionExample\"><div class=\"accordion-body\">\r\n                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n            </div></div></div>\r\n    <div class=\"accordion-item mt-3\"><h2 class=\"accordion-header\" id=\"headingThree\"><button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\" aria-expanded=\"false\" aria-controls=\"collapseThree\">\r\n                How to find what you are looking for\r\n            </button></h2>\r\n        <div id=\"collapseThree\" class=\"accordion-collapse collapse\" aria-labelledby=\"headingThree\" data-bs-parent=\"#accordionExample\"><div class=\"accordion-body\">\r\n                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n            </div></div></div>\r\n    <div class=\"accordion-item mt-3\"><h2 class=\"accordion-header\" id=\"headingFour\"><button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\" aria-expanded=\"true\" aria-controls=\"collapseFour\">\r\n                Understanding your tests\r\n            </button></h2>\r\n        <div id=\"collapseFour\" class=\"accordion-collapse collapse show\" aria-labelledby=\"headingFour\" data-bs-parent=\"#accordionExample\"><div class=\"accordion-body\"><div class=\"mb-4\"><h6 class=\"pt-3\"><strong>Your role</strong></h6>\r\n                   <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod\r\n                       tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation\r\n                        ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></div>\r\n               <div class=\"mb-4\"><h6 class=\"pt-3\"><strong>Provide all relevant information</strong></h6>\r\n                   <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod\r\n                       tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation\r\n                        ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></div>\r\n               <div class=\"mb-4\"><h6 class=\"pt-3\"><strong>Ask questions</strong></h6>\r\n                   <ul><li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</li>\r\n                       <li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</li>\r\n                       <li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</li>\r\n                       <li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</li></ul></div>\r\n               <div class=\"mb-4\"><h6 class=\"pt-3\"><strong>Follow instructions</strong></h6>\r\n                   <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod\r\n                       tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation\r\n                        ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></div>\r\n               <div class=\"mb-4\"><h6 class=\"pt-3\"><strong>Examples of Test Preparation</strong></h6>\r\n                   <ul><li class=\"colour__ex pb-1\">Fasting</li>\r\n                      \r\n                           <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod\r\n                            tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation\r\n                             ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>\r\n\r\n                        <li class=\"colour__ex pb-1\">Diet</li>\r\n                        \r\n                             <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod\r\n                              tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation\r\n                               ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>\r\n                        \r\n                          <li class=\"colour__ex pb-1\">Smocking and alcohol</li>\r\n                          \r\n                              <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod\r\n                               tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation\r\n                                ullamco laboris nisi ut aliquip ex ea commodo consequat.\r\n                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et\r\n                                 dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></ul></div>\r\n               <div class=\"last__review\">Last Review. 1st August, 2021</div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
