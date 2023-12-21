

using System.ComponentModel.DataAnnotations;

namespace OneApplyDataAccessLayer.Entities;

public class BaseEntity
{
    [Required, Key]
    public int Id { get; set; }
}
