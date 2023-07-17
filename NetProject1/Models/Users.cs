using System.ComponentModel.DataAnnotations;

namespace NetProject1.Models
{
    public class User
    {
        [Key]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public bool Role { get; set; }
        public int Email { get; set; }





    }
}
