using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace PHDSolutions.Shared
{
    public class MaterialMaster
    {
        [Key]
        public int uid { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
    }
}
