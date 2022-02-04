using System.ComponentModel.DataAnnotations;

namespace API_BasicAuthentication.NewFolder
{
    public class UserRecord
    {
        [Key]
        public string UserName { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
    }
}
