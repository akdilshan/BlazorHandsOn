#pragma checksum "/Users/dilshan/Projects/SampleBlazor/Shared/NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40bf9ad73ac2838fa8c23df7a31396b7a95f2cd3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SampleBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using SampleBlazor;
    using SampleBlazor.Shared;
    public class NavMenu : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 28 "/Users/dilshan/Projects/SampleBlazor/Shared/NavMenu.cshtml"
            
    bool collapseNavMenu = true;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
