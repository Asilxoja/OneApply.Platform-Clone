

using System.ComponentModel.DataAnnotations;

namespace OneApplyDataAccessLayer.Entities.Roles;

public class AspNetRole:BaseEntity
{
    [Required, MinLength(3), MaxLength(200)]
    public string Name { get; set; } = string.Empty;
    public ICollection<AspNetUserRole> AspNetUserRoles { get; set; } = new List<AspNetUserRole>();
}
