#pragma checksum "C:\Code\autoimport\Components\TabSet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4612efc4b4aacb1ca43ad0a143ed91f7667e546f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MappingsSquad.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\autoimport\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\autoimport\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\autoimport\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\autoimport\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\autoimport\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\autoimport\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\autoimport\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\autoimport\_Imports.razor"
using MappingsSquad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\autoimport\_Imports.razor"
using MappingsSquad.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\autoimport\_Imports.razor"
using MappingsSquad.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\autoimport\_Imports.razor"
using MappingsSquad.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\autoimport\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\autoimport\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
    public partial class TabSet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Code\autoimport\Components\TabSet.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public ITab ActiveTab { get; private set; }

    public void AddTab(ITab tab)
    {
        if (ActiveTab == null)
        {
            SetActiveTab(tab);
        }
    }

    public void SetActiveTab(ITab tab)
    {
        if (ActiveTab != tab)
        {
            ActiveTab = tab;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
