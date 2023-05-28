using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.ViewModels
{
    public class ClientViewModel
    {
        public string? Name { get; set; }
        public long CreatedTime { get; set; }
        public long LastChangeTime { get; set; }

    }
}