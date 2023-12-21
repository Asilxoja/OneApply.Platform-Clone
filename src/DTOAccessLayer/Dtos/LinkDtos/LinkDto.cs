

using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.LinkDtos;

public class LinkDto:BaseDto
{
    [Required(ErrorMessage = "Url is required")]
    [StringLength(500, ErrorMessage = "Url length must be between 1 and 500 characters", MinimumLength = 1)]
    public string Url { get; set; } = string.Empty;

    public LinkType Type { get; set; }

    public string UserId { get; set; } = string.Empty;
}
