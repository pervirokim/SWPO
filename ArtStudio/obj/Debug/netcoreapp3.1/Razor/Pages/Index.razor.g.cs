#pragma checksum "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773dfc45abd2d49c935523ceb1d5120783a162d0"
// <auto-generated/>
#pragma warning disable 1591
namespace ArtStudio.Pages
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
#line 2 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
using ArtStudio.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ArtStudio.Component.ArtVideo>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "index-container");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudGrid>(5);
            __builder.AddAttribute(6, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                      1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n");
#nullable restore
#line 7 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
         for(int i=0;i<10;i++)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "            ");
                __builder2.OpenComponent<MudBlazor.MudItem>(10);
                __builder2.AddAttribute(11, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                        6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                             3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Class", "card_block");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudCard>(16);
                    __builder3.AddAttribute(17, "Class", "scale-in-center");
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(19, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudCardMedia>(20);
                        __builder4.AddAttribute(21, "Image", "/img/SimplePhoto.jpg");
                        __builder4.AddAttribute(22, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                                                       200

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudCardContent>(24);
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(26, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudText>(27);
                            __builder5.AddAttribute(28, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 13 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                         MudBlazor.Color.Dark

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(29, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 13 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                                                     Typo.h5

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(31, "Old Paint");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(32, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudText>(33);
                            __builder5.AddAttribute(34, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 14 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                        MudBlazor.Color.Dark

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(35, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 14 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                                                    Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(37, "Old paint found on a stone house door.");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(38, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudText>(39);
                            __builder5.AddAttribute(40, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                        MudBlazor.Color.Dark

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(41, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 15 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                                                    Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(43, "This photo was taken in a small village in Istra Croatia.");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(44, "\r\n                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudCardActions>(46);
                        __builder4.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(48, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(49);
                            __builder5.AddAttribute(50, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                              Icons.Material.Filled.Favorite

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(51, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 18 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                                                                     Color.Default

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(52, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(53);
                            __builder5.AddAttribute(54, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                              Icons.Material.Filled.Share

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(55, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                                                                  Color.Default

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(56, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(57);
                            __builder5.AddAttribute(58, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                              Icons.Material.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(59, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
                                                                                         Color.Default

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(60, "\r\n                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n");
#nullable restore
#line 24 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(64, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\pervi\source\repos\ArtStudio\ArtStudio\Pages\Index.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591