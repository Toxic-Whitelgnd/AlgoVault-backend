using System.ComponentModel.DataAnnotations;

namespace LoginSignup.Models
{
    public class DSAmodel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UId { get; set; }

        [Required]
        public string? DSAName { get; set; }

        [Required]
        public string? DSAQuestion { get; set;}

        [Required]
        public string? DSAAnswer { get; set;}

        [Required]
        public string? DSAFrom { get; set;}

        [Required]
        public string? DSALevel { get; set;}

        [Required]
        public string? DSAIntuition { get; set;}

        [Required]
        public string? DSALanguage { get; set;}

    }
}
