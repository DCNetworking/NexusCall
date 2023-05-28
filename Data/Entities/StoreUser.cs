

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace nexus_connect.Data.Entities;
public class StoreUser : IdentityUser
{
    [MaxLength(255)]
    [Required]
    public string? FirstName { get; set; }
    [MaxLength(255)]
    [Required]
    public string? LastName { get; set; }
}