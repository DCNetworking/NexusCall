

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace nexus_connect.Data.Entities;
public class StoreUser : IdentityUser
{
    [Required]
    [EnumDataType(typeof(StatusType))]
    public StatusType Status { get; set; }

    [Required]
    [EnumDataType(typeof(PermissionType))]
    public PermissionType Permission { get; set; }
    [MaxLength(255)]
    [Required]
    public string? FirstName { get; set; }
    [MaxLength(255)]
    [Required]
    public string? LastName { get; set; }
}