#pragma checksum "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\Tab.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e16bac348da0804b6283d5f60034c7f7ba0b1a"
// <auto-generated/>
#pragma warning disable 1591
namespace MappingsSquad.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using MappingsSquad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using MappingsSquad.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using MappingsSquad.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using MappingsSquad.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
    public partial class Tab : Microsoft.AspNetCore.Components.ComponentBase, ITab
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\Tab.razor"
                 ActivateTab

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "nav-link" + " tab-purple" + " " + (
#nullable restore
#line 4 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\Tab.razor"
                                                          TitleCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "role", "button");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\Tab.razor"
         Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\Tab.razor"
       
    [CascadingParameter]
    public TabSet ContainerTabSet { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private string TitleCssClass => ContainerTabSet.ActiveTab == this ? "active" : null;

    protected override void OnInitialized()
    {
        ContainerTabSet.AddTab(this);
    }

    private void ActivateTab()
    {
        ContainerTabSet.SetActiveTab(this);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
