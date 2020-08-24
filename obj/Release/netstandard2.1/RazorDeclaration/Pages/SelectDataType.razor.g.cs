#pragma checksum "C:\Code\autoimport\Pages\SelectDataType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2d113e38c41c2d40a063f0af1bdf4e70c623843"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MappingsSquad.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 2 "C:\Code\autoimport\Pages\SelectDataType.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class SelectDataType : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Code\autoimport\Pages\SelectDataType.razor"
       
    private LabelAndValue selectedDataType = new LabelAndValue();

    private bool showOverlay = true;

    private bool loading = true;

    private List<LabelAndValue> dataTypes = new List<LabelAndValue>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await sessionStorage.ClearAsync();
            dataTypes = await Http.GetFromJsonAsync<List<LabelAndValue>>("api/Innovation/GetMappingImportTypes2?DBUsername=ZBN0236&Password=52287F9C-6BCE-4868-A3AE-6939D4FD2448");
            loading = false;
        }
        catch (Exception ex)
        {

        }
    }

    private async Task SelectData(LabelAndValue dataType)
    {
        selectedDataType = dataType;
        await sessionStorage.SetItemAsync<LabelAndValue>("selectedDataType", dataType);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
