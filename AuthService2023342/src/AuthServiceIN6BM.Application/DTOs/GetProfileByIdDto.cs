using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Application.DTOs;

public class GetProfilByIdDto
{
    [Required(ErrorMessage = "El userId es requerido")]
    public string UserId {get; set;} = string.Empty;
}