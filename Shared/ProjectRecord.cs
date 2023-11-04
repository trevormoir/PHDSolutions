using System.ComponentModel.DataAnnotations;

namespace PHDSolutions.Shared
{
    public class ProjectRecord
    {
        [Key]
        public int uid { get; set; }
        public string projectNumber { get; set; }
        public string projectDescription { get; set; }
    }
}
