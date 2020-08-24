#pragma checksum "C:\Code\autoimport\Components\MappingField.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c007330a311ec52c116caf4e436a0aa7c9e015cf"
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
    public partial class MappingField : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row no-gutters d-flex align-items-baseline my-0 p-1");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Code\autoimport\Components\MappingField.razor"
                                                                             async (e) => await SelectMappedField()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mapping-field px-2 py-1 rounded d-flex flex-row bg-white justify-content-between align-items-baseline flex-grow-1");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-1 no-gutters mx-1 blur-purple font-weight-bolder text-uppercase");
            __builder.AddContent(9, " ");
            __builder.AddContent(10, 
#nullable restore
#line 3 "C:\Code\autoimport\Components\MappingField.razor"
                                                                                           MappedField.Column

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-4 no-gutters font-weight-bold");
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 4 "C:\Code\autoimport\Components\MappingField.razor"
                                                         MappedField.Header

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, "<div class=\"col-1 no-gutters align-self-center mx-1 blur-purple font-weight-bolder\">\r\n            <i class=\"fas fa-arrows-alt-h\" style=\"font-size: 1.6em\"></i>\r\n        </div>\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-6 no-gutters pr-4");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "form-control font-weight-bold");
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Code\autoimport\Components\MappingField.razor"
                                                                     SelectField

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 10 "C:\Code\autoimport\Components\MappingField.razor"
                 foreach (var field in Fields)
                {
                    if (MappedField.Field?.ApiInternalName == field.ApiInternalName)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                        ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", 
#nullable restore
#line 14 "C:\Code\autoimport\Components\MappingField.razor"
                                        field.ApiInternalName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "selected", true);
            __builder.AddContent(31, 
#nullable restore
#line 14 "C:\Code\autoimport\Components\MappingField.razor"
                                                                         field.DisplayName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 15 "C:\Code\autoimport\Components\MappingField.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                        ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", 
#nullable restore
#line 18 "C:\Code\autoimport\Components\MappingField.razor"
                                        field.ApiInternalName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, 
#nullable restore
#line 18 "C:\Code\autoimport\Components\MappingField.razor"
                                                                field.DisplayName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 19 "C:\Code\autoimport\Components\MappingField.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "ml-4" + " " + (
#nullable restore
#line 24 "C:\Code\autoimport\Components\MappingField.razor"
                      iconState

#line default
#line hidden
#nullable disable
            ) + " align-self-center");
            __builder.AddAttribute(44, "style", "font-size: 1.2em;");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Code\autoimport\Components\MappingField.razor"
                                                                                       ToggleIconState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "\r\n        <i class=\"fas fa-check-circle\"></i>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Code\autoimport\Components\MappingField.razor"
       
    [Parameter] public List<ApiMappingField> Fields { get; set; } = new List<ApiMappingField>();
    [Parameter] public EventCallback<MappedField> OnConfirm { get; set; }
    [Parameter] public EventCallback<MappedField> OnSelect { get; set; }
    [Parameter] public MappedField MappedField { get; set; }

    private string iconState;

    protected override Task OnParametersSetAsync()
    {
        SetIconState();
        return base.OnParametersSetAsync();
    }

    private async Task SelectField(ChangeEventArgs e)
    {
        var filedMatch = Fields.Find(p => p.ApiInternalName == e.Value.ToString());
        MappedField.Field = filedMatch;
        await OnConfirm.InvokeAsync(MappedField);
    }

    private async Task SelectMappedField()
    {
        await OnSelect.InvokeAsync(MappedField);
    }

    private async Task ToggleIconState()
    {
        MappedField.Skip = !MappedField.Skip;
        SetIconState();
        await OnConfirm.InvokeAsync(MappedField);
    }

    private void SetIconState()
    {
        iconState = MappedField.Skip ? "check-icon" : "checked-icon";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
