#pragma checksum "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc015ee38516049986a9689b7fe230b73a82f56d"
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
#line 1 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using ArtStudio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using ArtStudio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\_Imports.razor"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
using ArtStudio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
using ArtStudio.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<link rel=""icon"" type=""image/png"" href=""images/icons/favicon.ico"">

<link rel=""stylesheet"" type=""text/css"" href=""vendor/bootstrap/css/bootstrap.min.css"">

<link rel=""stylesheet"" type=""text/css"" href=""fonts/font-awesome-4.7.0/css/font-awesome.min.css"">

<link rel=""stylesheet"" type=""text/css"" href=""fonts/iconic/css/material-design-iconic-font.min.css"">

<link rel=""stylesheet"" type=""text/css"" href=""vendor/animate/animate.css"">

<link rel=""stylesheet"" type=""text/css"" href=""vendor/css-hamburgers/hamburgers.min.css"">

<link rel=""stylesheet"" type=""text/css"" href=""vendor/animsition/css/animsition.min.css"">

<link rel=""stylesheet"" type=""text/css"" href=""vendor/select2/select2.min.css"">

<link rel=""stylesheet"" type=""text/css"" href=""vendor/daterangepicker/daterangepicker.css"">

<link rel=""stylesheet"" type=""text/css"" href=""css/util.css"">
<link rel=""stylesheet"" type=""text/css"" href=""css/main.css"">

");
            __builder.AddMarkupContent(1, "<div class=\"identity_bg \">\r\n</div>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "d-flex ca-d-center mt-2 pos-relative");
            __builder.AddAttribute(4, "style", "width:100%; ");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "wrap-login100");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "login100-form validate-form");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<h3 class=\"mb-3\">Профиль</h3>\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.AddMarkupContent(18, "<span class=\"control-label\">Email </span>\r\n                    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "disabled", true);
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                                                      User.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Email = __value, User.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.AddMarkupContent(29, "<span class=\"control-label\">Имя</span>\r\n                    ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "placeholder", "Введите ваше имя");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                                                                            User.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.FirstName = __value, User.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.AddMarkupContent(40, "<span class=\"control-label\">Фамилия </span>\r\n                    ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "placeholder", "Введите вашу фамилию");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                                                                                User.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.LastName = __value, User.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group");
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.AddMarkupContent(51, "<span class=\"control-label\">Местонахождение </span>\r\n                    ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "class", "form-control");
            __builder.AddAttribute(54, "placeholder", "Введите ваш город");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                                                                             User.Location

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Location = __value, User.Location));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group");
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.AddMarkupContent(62, "<span class=\"control-label\">Номер телефона </span>\r\n                    ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "class", "form-control");
            __builder.AddAttribute(65, "placeholder", "Введите ваш номер телефона");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                                                                                      User.PhoneNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.PhoneNumber = __value, User.PhoneNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "form-group");
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.AddMarkupContent(73, "<span class=\"control-label\">Количество купленых пакетов: </span>\r\n                    ");
            __builder.OpenElement(74, "span");
            __builder.AddAttribute(75, "class", "control-label");
            __builder.AddContent(76, 
#nullable restore
#line 62 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                                 CountOfPackages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.AddMarkupContent(82, "<span class=\"control-label\">Количество доступных скачиваний: </span>\r\n                    ");
            __builder.OpenElement(83, "span");
            __builder.AddAttribute(84, "class", "control-label");
            __builder.AddContent(85, 
#nullable restore
#line 66 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                                 User.CountOfDownload

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "form-group");
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.AddMarkupContent(91, "<span class=\"control-label\">Количество cкачиваний: </span>\r\n                    ");
            __builder.OpenElement(92, "span");
            __builder.AddAttribute(93, "class", "control-label");
            __builder.AddContent(94, 
#nullable restore
#line 70 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                                 User.CountOfSuccessDownload

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "container-login100-form-btn");
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
                                      UpdateProfile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "class", "login100-form-btn");
            __builder.AddMarkupContent(103, "\r\n                        Сохранить\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor"
      
    [Inject] private IDialogService DialogService { get; set; }

    public ApplicationUser User { get; set; }
    public Session Session { get; set; }
    public int CountOfDownloads { get; set; }
    public int CountOfPackages { get; set; }


    protected override  void OnInitialized()
    {

        Session = SessionService.GetSession();
        if (Session == null)
            NavigationManager.NavigateTo("/");
        CountOfPackages = UserService.GetUserCountOfPackages();
        User = dBContext.Users.FirstOrDefault(u => u.Id == Session.Id.ToString());
    }
    public async void UpdateProfile()
    {
        var result = await UserService.UpdateUserData(User);
        if (result)
            await DialogService.ShowMessageBox("","Данные успешно обновлены");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDBContext dBContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionService SessionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
