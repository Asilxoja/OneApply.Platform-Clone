using AutoMapper;
using BusnissLogicLayer.Extended;
using BusnissLogicLayer.Interfaces;
using BussnisLogicLayer.Extended;
using DTOAccessLayer.Dtos.LanguageDtos;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;
using OneApplyDataAccessLayer.Repositories;

namespace BusnissLogicLayer.Services;

public class LanguageService(IUnitOfWork unitOfWork, IMapper mapper) : ILanguageservice
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task Add(AddLanguageDto addLanguageDto)
    {
        if (addLanguageDto is null)
        {
            throw new ArgumentNullException($"{addLanguageDto} is null \n\n" ,nameof(addLanguageDto));
        }
        var language = _mapper.Map<Language>(addLanguageDto);
        if (!language.IsValid())
        {
            throw new CustomException("Languge Invalid");
        }

        var languages = await _unitOfWork.LanguageInterface.GetAllAsync();
        await _unitOfWork.LanguageInterface.AddAsync(language);
        await _unitOfWork.SaveAsync();
    }

    public async Task Delete(int id)
    {
        var language = await _unitOfWork.LanguageInterface.GetByIdAsync(id);
        if (language is null)
        {
            throw new ArgumentException("Bunday Category mavjud emas!");
        }

        await _unitOfWork.LanguageInterface.DeleteAsync(language);
        await _unitOfWork.SaveAsync();
    }

    public async Task<List<LanguageDto>> GetAllLanguagesAsync()
    {
        var languages = await _unitOfWork.LanguageInterface.GetAllAsync();
        return languages.Select(c => _mapper.Map<LanguageDto>(c))
                         .ToList();
    }

    public async Task<LanguageDto> GetByIdAsync(int id)
    {
        var language = await _unitOfWork.LanguageInterface.GetByIdAsync(id);
        if (language is null)
        {
            throw new ArgumentException("Category topilmadi!");
        }
        return _mapper.Map<LanguageDto>(language);
    }

    public async Task Update(UpdateLanguageDto updateLanguageDto)
    {
        if (updateLanguageDto is null)
        {
            throw new ArgumentNullException("language is null!");
        }
        var languages = await _unitOfWork.LanguageInterface.GetAllAsync();
        var language = languages.FirstOrDefault(c => c.Id == updateLanguageDto.Id);

        if (language is null)
        {
            throw new ArgumentNullException("Category topilmadi!");
        }

        var updateCategory = _mapper.Map<Language>(updateLanguageDto);
        if (!updateCategory.IsValid())
        {
            throw new CustomException("Language Invalid!");
        }
        await _unitOfWork.LanguageInterface.UpdateAsync(updateCategory);
        await _unitOfWork.SaveAsync();
    }
}
