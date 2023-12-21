using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneApplyDataAccessLayer.Entities.Resumes;

public class Language:BaseEntity
{
    [Required, MaxLength(255), MinLength(2)]
    public string Name {  get; set; } = string.Empty;

    public  LanguageType Lavel {  get; set; }

    [ForeignKey(nameof(User)), Column("UserId")]
    public string UserId { get; set; } = string.Empty;

    public User User { get; set; } = new();

}
