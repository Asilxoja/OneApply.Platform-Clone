

using OneApplyDataAccessLayer.Entities.Enums;

namespace DTOAccessLayer.Dtos.EducationDtos;

public class EducationDto : BaseDto
{
    public string Name { get; set; } = string.Empty;

    public LevelOfDegreeType LevelOfDegree { get; set; }

    public string Specialty { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool Present { get; set; }

    public string UserId { get; set; } = string.Empty;
}
