#pragma checksum "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\Pages\Doctor_consult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeab3c302fd7bc9b8ee15470b13c608874b1f8f1"
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
    public partial class Doctor_consult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"chat\"><header class=\"header mx-0\"><div class=\"header__left\"><div class=\"logo px-2\"><img src=\"Logo.png\" alt=\"Scynett\"></div>\r\n       <small class=\"px-2\">Good morning.</small>\r\n       <span>Dr. Meliano Esco</span></div>\r\n     <div class=\"header__right\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-bell\" viewBox=\"0 0 16 16\"><path d=\"M8 16a2 2 0 0 0 2-2H6a2 2 0 0 0 2 2zM8 1.918l-.797.161A4.002 4.002 0 0 0 4 6c0 .628-.134 2.197-.459 3.742-.16.767-.376 1.566-.663 2.258h10.244c-.287-.692-.502-1.49-.663-2.258C12.134 8.197 12 6.628 12 6a4.002 4.002 0 0 0-3.203-3.92L8 1.917zM14.22 12c.223.447.481.801.78 1H1c.299-.199.557-.553.78-1C2.68 10.2 3 6.88 3 6c0-2.42 1.72-4.44 4.005-4.901a1 1 0 1 1 1.99 0A5.002 5.002 0 0 1 13 6c0 .88.32 4.2 1.22 6z\"></path></svg>\r\n       <div class=\"header__right__ui\"><p>ME</p></div>\r\n       <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-chevron-down\" viewBox=\"0 0 16 16\"><path fill-rule=\"evenodd\" d=\"M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z\"></path></svg></div></header>\r\n  <body class=\"body\"><div class=\"main__contents\"><div class=\"health__record\"><div class=\"health__record__items\"><div class=\"health__record__items__demagraphics\"><img src=\"appointment.png\" alt=\"demographics\">\r\n                    <p>Appiontments</p></div>\r\n                 <div class=\"health__record__items__notes\"><img src=\"patient.png\" alt=\"demographics\">\r\n                    <p>All patients</p></div>\r\n                 <div class=\"health__record__items__lab\"><img src=\"cashless-payment.png\" alt=\"demographics\">\r\n                    <p>Payments</p></div>\r\n                 <div class=\"health__record__items__medication\"><img src=\"planner.png\" alt=\"demographics\">\r\n                    <p>Events</p></div></div></div>\r\n         <div></div>\r\n         <div class=\"patient__infor\"><div class=\"consult__chat__header__left\"><h6 class=\"mx-3 pt-1\"> Caleb Forster</h6>\r\n                <small class=\"mx-2\">Age: 34years</small>\r\n                <small class=\"mx-2\">|</small>\r\n                <small class=\"mx-2\">Blood Group: B+</small></div>\r\n             <div class=\"consult__chat__header__end px-3\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-plus\" viewBox=\"0 0 16 16\"><path d=\"M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z\"></path></svg></div></div>\r\n         <div class=\"consult__chat\"><div class=\"consult__chat__header\"><div class=\"consult__chat__header__left\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-arrow-left\" viewBox=\"0 0 16 16\"><path fill-rule=\"evenodd\" d=\"M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z\"></path></svg>\r\n                    <h6>Consultation with Caleb Forster</h6></div>\r\n                <div class=\"consult__chat__header__right\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-camera-video\" viewBox=\"0 0 16 16\"><path fill-rule=\"evenodd\" d=\"M0 5a2 2 0 0 1 2-2h7.5a2 2 0 0 1 1.983 1.738l3.11-1.382A1 1 0 0 1 16 4.269v7.462a1 1 0 0 1-1.406.913l-3.111-1.382A2 2 0 0 1 9.5 13H2a2 2 0 0 1-2-2V5zm11.5 5.175 3.5 1.556V4.269l-3.5 1.556v4.35zM2 4a1 1 0 0 0-1 1v6a1 1 0 0 0 1 1h7.5a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H2z\"></path></svg>\r\n                  <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-telephone\" viewBox=\"0 0 16 16\"><path d=\"M3.654 1.328a.678.678 0 0 0-1.015-.063L1.605 2.3c-.483.484-.661 1.169-.45 1.77a17.568 17.568 0 0 0 4.168 6.608 17.569 17.569 0 0 0 6.608 4.168c.601.211 1.286.033 1.77-.45l1.034-1.034a.678.678 0 0 0-.063-1.015l-2.307-1.794a.678.678 0 0 0-.58-.122l-2.19.547a1.745 1.745 0 0 1-1.657-.459L5.482 8.062a1.745 1.745 0 0 1-.46-1.657l.548-2.19a.678.678 0 0 0-.122-.58L3.654 1.328zM1.884.511a1.745 1.745 0 0 1 2.612.163L6.29 2.98c.329.423.445.974.315 1.494l-.547 2.19a.678.678 0 0 0 .178.643l2.457 2.457a.678.678 0 0 0 .644.178l2.189-.547a1.745 1.745 0 0 1 1.494.315l2.306 1.794c.829.645.905 1.87.163 2.611l-1.034 1.034c-.74.74-1.846 1.065-2.877.702a18.634 18.634 0 0 1-7.01-4.42 18.634 18.634 0 0 1-4.42-7.009c-.362-1.03-.037-2.137.703-2.877L1.885.511z\"></path></svg>\r\n                 <div class=\"consult__chat__header__right__chat mx-2\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-chat-dots\" viewBox=\"0 0 16 16\"><path d=\"M5 8a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm4 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm3 1a1 1 0 1 0 0-2 1 1 0 0 0 0 2z\"></path>\r\n                    <path d=\"m2.165 15.803.02-.004c1.83-.363 2.948-.842 3.468-1.105A9.06 9.06 0 0 0 8 15c4.418 0 8-3.134 8-7s-3.582-7-8-7-8 3.134-8 7c0 1.76.743 3.37 1.97 4.6a10.437 10.437 0 0 1-.524 2.318l-.003.011a10.722 10.722 0 0 1-.244.637c-.079.186.074.394.273.362a21.673 21.673 0 0 0 .693-.125zm.8-3.108a1 1 0 0 0-.287-.801C1.618 10.83 1 9.468 1 8c0-3.192 3.004-6 7-6s7 2.808 7 6c0 3.193-3.004 6-7 6a8.06 8.06 0 0 1-2.088-.272 1 1 0 0 0-.711.074c-.387.196-1.24.57-2.634.893a10.97 10.97 0 0 0 .398-2z\"></path></svg>\r\n                  <span class=\"end__chat\">End chats</span></div>\r\n                 \r\n                 <div class=\"cancel-btn text-center\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-x\" viewBox=\"0 0 16 16\"><path d=\"M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z\"></path></svg></div></div></div>\r\n                <div class=\"chat__contents\"><div class=\"chat__contents__left\"><div class=\"chat__contents__left__items\"><strong>complains</strong>\r\n                         <div class=\"chat__contents__left__complains\"><p>For over a week now I have not been able to sleep well while also unable to eat\r\n                              I bought some medications from a nearby pharmacy which seams to have worsen my situation\r\n                            </p></div></div>\r\n                      <div class=\"chat__contents__left__items\"><strong>symtoms</strong>\r\n                        <div class=\"chat__contents__left__complains\"><ul><li>High body temperature</li>\r\n                            <li>Head ach</li>\r\n                            <li>Lack of appetite for food</li>\r\n                            <li>Cold</li>\r\n                            <li>body pains</li></ul></div></div>\r\n                      <div class=\"chat__contents__left__items\"><strong>consultation note</strong>\r\n                        <div class=\"chat__contents__left__complains\"><p></p></div></div>\r\n                      <button class=\"btn-primary mt-5\">Save</button></div>\r\n                   <div class=\"chat__contents__right\"><div class=\"chat__contents__right__messages\"><div class=\"chat__contents__right__messages__sender\"><small><strong>Caleb Forster</strong></small>\r\n                          <div class=\"chat__contents__right__messages__sender__content\"><p>High body temperature, lack of appetite for food, cold and body pains</p>\r\n                              <small class=\"message__time\">09:50 PM</small></div></div>\r\n                       <div class=\"chat__contents__right__messages__receive mx-2\"><div><small class=\"d-flex justify-content-end px-2\"><strong>You</strong></small>\r\n                             <div class=\"chat__contents__right__messages__receiver__content\"><p class=\" d-flex justify-content-end\">Hello</p>\r\n                                 <small class=\"message__time\">09:50 PM</small></div></div></div></div>\r\n                       <hr class=\"message__hr\">\r\n                       <div class=\"chat__input\"><div class=\"chat__input__message\"><input type=\"text\" name=\"message\" placeholder=\"Type your message here\">\r\n                          <div class=\"chat__input__icons\"><img src=\"telegram.png\" alt=\"tele\"></div></div>\r\n                          <div class=\"chat__input__icons\"><img src=\"mic.png\" alt=\"tele\"></div></div></div></div></div></div></body>\r\n  <footer class=\"footer\"><div class=\"copyright mx-5\"><small class=\"copyright__item\">Scycare</small>\r\n         <span><small class=\"copyright__item\">&copy 2021 Powered by SCYNETT</small></span></div>\r\n      <div class=\"copyright mx-5\"><small class=\"copyright__item\">Version 1.0.0.0</small></div></footer></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
