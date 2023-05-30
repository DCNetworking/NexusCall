using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.ViewModels
{
    public class SignUpViewModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "Name is required with min 3 chars length")]
        public string? FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "LastName is Required qith minimum 2 chars")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        public string? Username { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
        ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string? Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwords are not equals")]
        public string? PasswordVerify { get; set; }
    }
}