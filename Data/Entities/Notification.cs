using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.Data.Entities
{
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(150)]
        [Required]
        public string? Title { get; set; }
        [MaxLength(255)]
        [Required]
        public string? Message { get; set; }
        public long DisplayTimestamp { get; set; }
        public long CreatedTimestamp { get; set; }
        public long ReadedTimeStamp { get; set; }
        [ForeignKey("Uid")]
        public string? Uid { get; set; }
        [ForeignKey("CreatedUid")]
        public string? CreatedUid { get; set; }
        [ForeignKey("Cid")]
        public int Cid { get; set; }
        public bool Important { get; set; }
    }
}