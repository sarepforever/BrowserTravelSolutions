#pragma checksum "C:\Users\sarep\source\repos\BrowserTravel\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0abf6bab0c46e345309fe6b11de0bb51b527ddcb"
// <auto-generated/>
#pragma warning disable 1591
namespace BrowserTravel.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using BrowserTravel.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using BrowserTravel.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using BrowserTravel.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sarep\source\repos\BrowserTravel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "C:\Users\sarep\source\repos\BrowserTravel\Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "PreferExactMatches", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "C:\Users\sarep\source\repos\BrowserTravel\Client\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(4);
                __builder2.AddAttribute(5, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "C:\Users\sarep\source\repos\BrowserTravel\Client\App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "C:\Users\sarep\source\repos\BrowserTravel\Client\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                    __builder3.AddAttribute(11, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 7 "C:\Users\sarep\source\repos\BrowserTravel\Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
