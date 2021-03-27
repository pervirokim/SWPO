#pragma checksum "C:\Users\pervi\Desktop\New folder\SWPO\ArtStudio\Pages\Identity\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc015ee38516049986a9689b7fe230b73a82f56d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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