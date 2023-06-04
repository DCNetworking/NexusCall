using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.ViewModels
{
    public class NotificationViewModel
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Message { get; set; }
        public string? CreatedUid { get; set; }
        public string? CreatedUserName { get; set; }
        public long CreatedTimestamp { get; set; }
        public int Cid { get; set; }
        public long ReadedTimeStamp { get; set; }
        public bool Important { get; set; }
    }
}