
using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.VacanceDtos.ApplyDtos;

public class ApplyDto:BaseDto
{
    [Required(ErrorMessage = "JobId is required")]
    public int JobId { get; set; }

    [Required(ErrorMessage = "UserId is required")]
    public string UserId { get; set; } = string.Empty;

    public ApplyStatus Status { get; set; }
}
