
using OneApplyDataAccessLayer.Entities.Enums;

namespace DTOAccessLayer.Dtos.LanguageDtos;

public class LanguageDto
{
    public string Name { get; set; } = string.Empty;

    public LanguageType Level { get; set; }

    public string UserId { get; set; } = string.Empty;
}
