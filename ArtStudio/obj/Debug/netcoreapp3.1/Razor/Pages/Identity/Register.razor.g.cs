#pragma checksum "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Identity\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49524f34e0fb9582071057075cfd2fc89c9d5669"
// <auto-generated/>
#pragma warning disable 1591
namespace ArtStudio.Pages.Identity
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using ArtStudio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\_Imports.razor"
using ArtStudio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Identity\Register.razor"
using ArtStudio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Identity\Register.razor"
using ArtStudio.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-10 col-xl-9 mx-auto");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card card-signin flex-row my-5");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<div class=\"card-img-left d-none d-md-flex\">\r\n                    \r\n                </div>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<h5 class=\"card-title text-center\">Регистрация</h5>\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-signin");
            __builder.AddMarkupContent(19, "\r\n\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-label-group");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "email");
            __builder.AddAttribute(25, "id", "inputEmail");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "placeholder", "Email");
            __builder.AddAttribute(28, "required", true);
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Identity\Register.razor"
                                                                              registerModel.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerModel.Email = __value, registerModel.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.AddMarkupContent(32, "<label for=\"inputEmail\">Введите Email</label>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n                        <hr>\r\n\r\n                        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-label-group");
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "password");
            __builder.AddAttribute(39, "id", "inputPassword");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "placeholder", "Пароль");
            __builder.AddAttribute(42, "required", true);
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Identity\Register.razor"
                                                                                    registerModel.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerModel.Password = __value, registerModel.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.AddMarkupContent(46, "<label for=\"inputPassword\">Ведите пароль</label>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n                        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-label-group");
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "password");
            __builder.AddAttribute(53, "id", "inputConfirmPassword");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "placeholder", "Пароль");
            __builder.AddAttribute(56, "required", true);
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Identity\Register.razor"
                                                                                           registerModel.ConfirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerModel.ConfirmPassword = __value, registerModel.ConfirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                            ");
            __builder.AddMarkupContent(60, "<label for=\"inputConfirmPassword\">Подтвердите пароль</label>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n                        ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-lg btn-primary btn-block text-uppercase");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Identity\Register.razor"
                                                                                                  RegisterRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "Регистрация");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.AddMarkupContent(67, "<a class=\"d-block text-center mt-2 small\" href=\"/login\">Есть аккаунт? Войти</a>\r\n                        <hr class=\"my-4\">\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Identity\Register.razor"
      
    public RegisterModel registerModel = new RegisterModel() { ConfirmPassword = "!Q2w3e4r5t", Email = "kashperuk99@gmail.com", Password = "!Q2w3e4r5t" };


    public async void RegisterRequest()
    {
        if (!String.IsNullOrEmpty(registerModel.ConfirmPassword) && !String.IsNullOrEmpty(registerModel.Email) && !String.IsNullOrEmpty(registerModel.Password))
        {
            var result = await JSRuntimeService.InvokeScript("SendRequest", new { type = "post", url = "/api/user/login", data = registerModel, contentType = "application/json" });
            if (result.status)
            {
                NavigationManager.NavigateTo("/", true);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JSRuntimeService JSRuntimeService { get; set; }
    }
}
#pragma warning restore 1591
