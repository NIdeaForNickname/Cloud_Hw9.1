using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication15.Models;

[Table("Users")]
public class UserViewModel
{
    [Key]
    public int Id { get; set; }
        
    public string Nickname { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    public DateTime LastLoginDate { get; set; }
    public string AvatarUrl { get; set; } = "https://via.placeholder.com/150";
}