using System.ComponentModel.DataAnnotations;

namespace PHDSolutions.Shared
{
    public class User
    {
        [Key]
        public int uid { get; set; }
        public string userName { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
    }
}
