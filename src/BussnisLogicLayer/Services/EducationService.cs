using AutoMapper;
using BusnissLogicLayer.Extended;
using BusnissLogicLayer.Helpers;
using BusnissLogicLayer.Interfaces;
using BussnisLogicLayer.Extended;
using DTOAccessLayer.Dtos.EducationDtos;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace BusnissLogicLayer.Services;

public class EducationService(IUnitOfWork unitOfWork,
                              IMapper mapper)
    : IEducatonService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task Add(AddEducationDto educationDto)
    {   
        if (educationDto is null)
        {
            throw new ArgumentNullException("Category is null");
        }

        var education = _mapper.Map<Education>(educationDto);
        if (!education.IsValid())
        {
            throw new CustomException("Invalid Education");
        }
        await _unitOfWork.EducationInterface.AddAsync(education);
        await _unitOfWork.SaveAsync();

    }

    public async Task Delete(int id)
    {
        var education = await _unitOfWork.EducationInterface.GetByIdAsync(id);
        if (education is null)
        {
            throw new ArgumentException("Education is null");
        }
        await _unitOfWork.EducationInterface.DeleteAsync(education);
        await _unitOfWork.SaveAsync();

    }

    public async Task<List<EducationDto>> GetAllAsync()
    {
        var educations = await _unitOfWork.EducationInterface.GetAllAsync();
        return educations.Select(e => _mapper.Map<EducationDto>(e))
                         .ToList();
    }

    public async Task<PagedList<EducationDto>> GetAllPagedAsync(int pageSize, int pageNumber)
    {
        var edudations = await GetAllAsync();
        PagedList<EducationDto> pagedList = new(edudations, edudations.Count, pageNumber, pageSize);
        return pagedList.ToPagedList(edudations,
                                      pageSize,
                                      pageNumber);
    }

    public async Task<EducationDto> GetByIdAsync(int id)
    {
        var edudation = await _unitOfWork.EducationInterface.GetByIdAsync(id);
        if (edudation is null)
        {
            throw new ArgumentException("Education is not");
        }
        return _mapper.Map<EducationDto>(edudation);
    }

    public async Task Update(UpdateEducationDto updatedEducationDto)
    {
        if (updatedEducationDto is null)
        {
            throw new ArgumentNullException("Education is null");
        }
        var educations = await _unitOfWork.EducationInterface.GetAllAsync();
        var euducation = educations.FirstOrDefault(e => e.Id == updatedEducationDto.Id);
        if (euducation is null)
        {
            throw new ArgumentException("Education is null");
        }
        var updateDto = _mapper.Map<Education>(updatedEducationDto);
        if (!updateDto.IsValid())
        {
            throw new CustomException("Education Invalid!");
        }
        await _unitOfWork.EducationInterface.UpdateAsync(updateDto);
        await _unitOfWork.SaveAsync();
    }
}
