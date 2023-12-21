

using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.RoleDtos.AspNetRoleDtos;

public class UpdateAspNetRoleDto:BaseDto
{
    [StringLength(200, ErrorMessage = "Name length must be between 3 and 200 characters", MinimumLength = 3)]
    public string Name { get; set; } = string.Empty;
}
