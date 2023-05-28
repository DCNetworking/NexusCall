using System.ComponentModel.DataAnnotations.Schema;




using System.ComponentModel.DataAnnotations;
namespace nexus_connect.Data.Entities;
public class Client
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? LocalUrl { get; set; }
    public string? Name { get; set; }
    public long CreatedTime { get; set; }
    public long LastChangeTime { get; set; }
    [Column(TypeName = "json")]
    public string? Options { get; set; }
}