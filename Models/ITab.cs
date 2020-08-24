using Microsoft.AspNetCore.Components;

namespace MappingsSquad.Models
{
    public interface ITab
    {
        RenderFragment ChildContent { get; set; }
    }
}
