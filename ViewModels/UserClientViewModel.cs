using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.ViewModels
{
    public class UserClientViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long CreatedTimestamp { get; set; }
        public long LastChangeTimestamp { get; set; }
        public Data.PermissionType AccessPermission { get; set; }

    }
}