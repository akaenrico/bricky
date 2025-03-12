using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bricky.Models;

public class User
{
  [Key]
  [Required]
  public required string Id { get; set; }

  [Required]
  public required string Name { get; set; }

  [EmailAddress]
  [Required]
  public required string Email { get; set; }

  [Required]
  public required string HashedPassword { get; set; }

  [ForeignKey("Role")]
  [Required]
  public int RoleId { get; set; }

  [Required]
  public int Karma { get; set; }

  [Required]
  public DateTime CreatedAt { get; set; }

  [Required]
  public DateTime UpdatedAt { get; set; }

  public DateTime? DeletedAt { get; set; }
}