using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.ViewModels
{
    public class LoginModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}