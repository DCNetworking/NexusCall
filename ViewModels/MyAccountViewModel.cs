using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.ViewModels
{
    public class MyAccountViewModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "Name is required with min 3 chars length")]
        public string? FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "LastName is Required qith minimum 2 chars")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        public string? Username { get; set; }
        public string? Email { get; set; }
    }
}