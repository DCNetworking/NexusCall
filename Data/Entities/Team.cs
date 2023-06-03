using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.Data.Entities
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Uid")]
        public string? Uid { get; set; }
        public string? Name { get; set; }
        public long CreatedTimestamp { get; set; }
        public long LastChangeTimestamp { get; set; }
        [ForeignKey("Cid")]
        public int Cid { get; set; }
        [Column(TypeName = "json")]
        public string? CidOther { get; set; }
        [EnumDataType(typeof(Data.StatusType))]
        public Data.StatusType Status { get; set; }
    }
}