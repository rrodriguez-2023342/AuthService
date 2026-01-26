using System.ComponentModel.DataAnnotations;
namespace AuthServiceIN6BM.Domain.Entities;


public class Role
{
    [Key]
    [MaxLength(16)]
    public string Id {get; set;} = string.Empty;

    [Required(ErrorMessage = "El nombre del rol es obligatorio ")]
    [MaxLength(100, ErrorMessage = "El nombre del rol no puede superar los 100 caracteres")]
    public string Name {get; set;} = string.Empty;

    public DateTime CreateAT {get; set;} = DateTime.UtcNow;

    public DateTime UpdateAT {get; set;} = DateTime.UtcNow;

    public ICollection<UserRole> UserRoles {get; set;} = [];
}