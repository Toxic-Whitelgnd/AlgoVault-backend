using System.ComponentModel.DataAnnotations;

namespace LoginSignup.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Phone { get; set; }

        [Required]
        public string? Email { get; set; }

        public string? Password { get; set; }


    }
}
