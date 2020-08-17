using System.ComponentModel.DataAnnotations;

namespace DotNetCodeAPI.BusinessObjects
{
    public class UserVM
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}
