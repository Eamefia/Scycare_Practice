#pragma checksum "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\Pages\Revenue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401827827a0ff49cbeee9f54f3562deb127cedf9"
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
#line 1 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using ScyLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using ScyLab.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/revenue")]
    public partial class Revenue : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main__item__right");
            __builder.AddMarkupContent(2, @"<div class=""all__email__sms""><div class=""all__sus pt-3""><small class=""ps-4"">GHS</small>
            <h4 class=""ps-4"">1,000,000.00</h4>
            <small class=""ps-4"">Total Revenue</small></div>
        <div class=""all__sus pt-3""><small class=""ps-4"">GHS</small>
            <h4 class=""ps-4"">500,000.00</h4>
            <small class=""ps-4"">Total Payments</small></div>
        <div class=""all__sus pt-3""><small class=""ps-4"">GHS</small>
            <h4 class=""ps-4"">500,000.00</h4>
            <small class=""ps-4"">Balance Due</small></div></div>
     ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main__item__right__form");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "add__all");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "entries__search__select");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "search__rec");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-select");
            __builder.AddAttribute(13, "aria-label", "Default select example");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "selected");
            __builder.AddContent(16, "Open this select menu");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", "1");
            __builder.AddContent(20, "One");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value", "2");
            __builder.AddContent(24, "Two");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "3");
            __builder.AddContent(28, "Three");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.AddMarkupContent(30, "<div class=\"table__sec\"><table class=\"table\"><tbody><tr><td class=\"py-3\" scope=\"col\">Time</td>\r\n                  <td class=\"py-3\" scope=\"col\">Transaction</td>\r\n                  <td class=\"py-3\" scope=\"col\">Transaction Type</td>\r\n                  <td class=\"py-3\" scope=\"col\" colspan=\"2\">Amount</td></tr>\r\n                <tr><td class=\"py-4\">04/03/2021 18:00 GMT</td>\r\n                  <td class=\"py-4\">Laboratory</td>\r\n                  <td class=\"py-4\">Invoice</td>\r\n                  <td class=\"py-4\">50.00</td>\r\n                  <td><div class=\"btn-group\"><button type=\"button\" class=\"btn\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\"><img class=\"three_dots\" src=\"three-dots.svg\"></button>\r\n                     <ul class=\"dropdown-menu\"><li><a class=\"dropdown-item\" href=\"#\">View</a></li>\r\n                       <li><a class=\"dropdown-item\" href=\"#\">Update</a></li>\r\n                       <li><a class=\"dropdown-item\" data-bs-toggle=\"modal\" data-bs-target=\"#staticBackdrop\" href=\"#\">Delete</a></li></ul></div></td></tr>\r\n                <tr><td class=\"py-4\">04/03/2021 18:00 GMT</td>\r\n                    <td class=\"py-4\">Online Consultation</td>\r\n                    <td class=\"py-4\">PPayment</td>\r\n                    <td class=\"py-4\">150.00</td>\r\n                    <td><div class=\"btn-group\"><button type=\"button\" class=\"btn\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\"><img class=\"three_dots\" src=\"three-dots.svg\"></button>\r\n                         <ul class=\"dropdown-menu\"><li><a class=\"dropdown-item\" href=\"#\">View</a></li>\r\n                           <li><a class=\"dropdown-item\" href=\"#\">Update</a></li>\r\n                           <li><a class=\"dropdown-item\" data-bs-toggle=\"modal\" data-bs-target=\"#staticBackdrop\" href=\"#\">Delete</a></li></ul></div></td></tr></tbody></table></div>\r\n       ");
            __builder.AddMarkupContent(31, @"<div class=""table__footer""><div class=""table__footer_left""><div class=""pagination""><a href=""#"" class=""pag-icon"">&laquo;</a>
             <a href=""#"" class=""pag-icon me-2""> &lsaquo;</a>
             <a href=""#"" class=""active pag-num"">1</a>
             <a href=""#"" class=""pag-num"">2</a>
             <a href=""#"" class=""pag-num"">3</a>
             <a href=""#"" class=""pag-num"">4</a>
             <a href=""#"" class=""pag-num"">5</a>
             <a href=""#"" class=""pag-icon ms-2"">&rsaquo;</a>
             <a href=""#"" class=""pag-icon"">&raquo;</a></div></div>
          <div class=""table__footer_right""><div class=""btn-group px-2""><button type=""button"" class=""btn rec-num"">10</button>
             <button type=""button"" class=""btn rec-num dropdown-toggle dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false""><span class=""visually-hidden"">Toggle Dropdown</span></button>
             <ul class=""dropdown-menu""><li><a class=""dropdown-item"" href=""#"">Action</a></li>
               <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
               <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
               <li><hr class=""dropdown-divider""></li>
               <li><a class=""dropdown-item"" href=""#"">Separated link</a></li></ul></div>
            <span class=""mt-2""><small>Displaying 10 out of 100 records</small></span></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
