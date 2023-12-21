﻿
using DTOAccessLayer.Dtos.VacanceDtos.ApplyDtos;
using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.VacanceDtos.JobDtos;

public class UpdateJobDto
{
    [Required(ErrorMessage = "Title is required")]
    [StringLength(500, ErrorMessage = "Title length must be between 3 and 500 characters", MinimumLength = 3)]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "DeadLine is required")]
    public DateTime DeadLine { get; set; }

    [Required(ErrorMessage = "EmploymentType is required")]
    public EmploymentType EmploymentType { get; set; }

    [StringLength(500, ErrorMessage = "Location length must be between 3 and 500 characters", MinimumLength = 3)]
    public string Location { get; set; } = string.Empty;

    [Required(ErrorMessage = "SalaryMin is required")]
    public decimal SalaryMin { get; set; }

    [Required(ErrorMessage = "SalaryMax is required")]
    public decimal SalaryMax { get; set; }

    [StringLength(2000, ErrorMessage = "Description length must be between 3 and 2000 characters", MinimumLength = 3)]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "UserId is required")]
    public string UserId { get; set; } = string.Empty;

    public ICollection<ApplyDto> ApplyDtos { get; set; } = new List<ApplyDto>();
}
