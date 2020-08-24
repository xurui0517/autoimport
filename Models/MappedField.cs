using System;
namespace MappingsSquad.Models
{
    public class MappedField
    {
        public string Column { get; set; }
        public string Header { get; set; }
        public ApiMappingField Field { get; set; }
        public bool Skip { get; set; }
    }
}
