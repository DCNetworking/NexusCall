using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.Data.Entities
{
    public class UserClient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("StoreUser")]
        public string? Uid { get; set; }
        public string? AccessGivenUid { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public long CreatedTimestamp { get; set; }
        public long LastChangeTimestamp { get; set; }
        public Data.StatusType Status { get; set; }
        public long BannedTimestamp { get; set; }
        public Data.PermissionType AccessPermission { get; set; }

    }
}