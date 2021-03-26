#pragma checksum "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee6cc6fda1242deb65d3a92eeb6c14a9548b8a1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ArtStudio.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using ArtStudio.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using ArtStudio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Shared\MainLayout.razor"
      


    public int CountOfCartContent = 0;

    public Session Session { get; set; }

    protected override void OnInitialized()
    {
        Session = SessionService.GetSession();
        if (Session != null)
            CountOfCartContent = dBContext.UserCartContents.Where(c => c.ApplicationUserId == Session.Id).Count();


    }


    public string HeaderBrand = "Sony World Photograpy Organization";
    public string HeaderToggleClass = "";
    MudTheme SWPO = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = "#9184EF",
            Secondary = "#4A5665",
            AppbarBackground = "#21272F",
            DrawerBackground = "#21272F",
            TextPrimary = "#ffffff",
            Divider = "#ffffff",
            PrimaryContrastText = "#ffffff",
            SecondaryContrastText = "rgba(255, 255, 255, 0.7);"

        },

        LayoutProperties = new LayoutProperties()
        {
            AppbarMinHeight = "0",
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "300px",


        },

        ZIndex = new ZIndex()
        {

        },
        Typography = new Typography()
        {
        }

    };

    bool open = false;
    string rotate = "t-3";

    void ToggleDrawer()
    {
        open = !open;
        rotate = open ? "rotate-180 t-3" : "t-3";
        HeaderBrand = open ? "" : "Sony World Photograpy Organization";
        HeaderToggleClass = open ? "slide-out-bck-left" : "slide-in-fwd-left";
    }

    public async void LogOut()
    {
        Response result = await JSRuntimeService.InvokeScript("SendRequest", new { type = "post", url = "/api/user/logout", data = "", contentType = "application/json" });
        if (result.isSuccess)
        {
            NavigationManager.NavigateTo("/", true);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EntityService entityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionService SessionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDBContext dBContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JSRuntimeService JSRuntimeService { get; set; }
    }
}
#pragma warning restore 1591
