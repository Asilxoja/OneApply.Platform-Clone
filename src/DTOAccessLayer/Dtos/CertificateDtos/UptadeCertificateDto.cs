
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.CertificateDtos;

public class UpdateCertificateDto
{

    [StringLength(555, ErrorMessage = "Name length must be between 3 and 555 characters", MinimumLength = 3)]
    public string Name { get; set; } = string.Empty;

    [StringLength(555, ErrorMessage = "Url length must be between 3 and 555 characters", MinimumLength = 3)]
    public string Url { get; set; } = string.Empty;

    public string UserId { get; set; } = string.Empty;
}
