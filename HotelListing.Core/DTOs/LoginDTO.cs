using System.ComponentModel.DataAnnotations;

namespace HotelListing.Core.DTOs
{
    public class LoginDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your password is limited to {2} to {1} characters", MinimumLength = 2)]
        public string Password { get; set; }
    }
}
