
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.RoleDtos.AspNetUserRoleDtos;

public class AddAspNetUserRoleDto
{
    [Required(ErrorMessage = "UserId is required")]
    public string UserId { get; set; } = string.Empty;

    [Required(ErrorMessage = "RoleId is required")]
    public int RoleId { get; set; }
}
