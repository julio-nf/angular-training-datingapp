using System.ComponentModel.DataAnnotations;

namespace AngularTraining.API.Dtos
{
    public class UserToCreateDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be a minimum of 6 characters.")]
        public string Password { get; set; }
    }
}