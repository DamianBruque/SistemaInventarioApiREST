using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class UserEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }
    [Required]
    public string UserName { get; set; }
    [Required]
    public string UserEmail { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public bool State { get; set; }
}
