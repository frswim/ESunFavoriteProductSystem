
using System.ComponentModel.DataAnnotations;

namespace ESun.Models
{
    public class User
    {
        [Key]
        public string UserID { get; set; }
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Account { get; set; }
    }
}
