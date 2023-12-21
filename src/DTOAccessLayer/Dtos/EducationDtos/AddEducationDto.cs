using OneApplyDataAccessLayer.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTOAccessLayer.Dtos.EducationDtos;

public class AddEducationDto
{

    [Required(ErrorMessage = "Name is required")]
    [StringLength(500, ErrorMessage = "Name length must be between 3 and 500 characters", MinimumLength = 3)]
    public string Name { get; set; }=string.Empty;

    [Required(ErrorMessage = "Level of degree is required")]
    public LevelOfDegreeType LevelOfDegree { get; set; }

    [StringLength(500, ErrorMessage = "Specialty length must be between 3 and 500 characters", MinimumLength = 3)]
    public string Specialty { get; set; } = string.Empty;

    [Required(ErrorMessage = "Start date is required")]
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool Present { get; set; }

    [Required(ErrorMessage = "UserId is required")]
    public string UserId { get; set; } = string.Empty;
}
