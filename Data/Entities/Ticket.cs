using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.Data.Entities
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RelId { get; set; }
        public long TicketCreatedTime { get; set; }
        public long TicketEndTime { get; set; }
        public long TicketLastChangeTime { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public TicketCaseType TicketCaseType { get; set; }
        [Column(TypeName = "json")]
        public string LogHistory { get; set; } = string.Empty;
        [ForeignKey("StoreUser")]
        public string? Uid { get; set; }
    }
}