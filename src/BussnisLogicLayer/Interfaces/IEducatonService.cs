using BusnissLogicLayer.Helpers;
using DTOAccessLayer.Dtos.EducationDtos;

namespace BusnissLogicLayer.Interfaces;

public interface IEducatonService
{
    Task<List<EducationDto>> GetAllAsync();
    Task<PagedList<EducationDto>> GetAllPagedAsync(int pageSize, int pageNumber);
    Task<EducationDto> GetByIdAsync(int id);
    Task Add(AddEducationDto educationDto);
    Task Update(UpdateEducationDto updatedEducationDto);
    Task Delete(int id);
}
