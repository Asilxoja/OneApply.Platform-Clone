using DTOAccessLayer.Dtos.LanguageDtos;

namespace BusnissLogicLayer.Interfaces;

public interface ILanguageservice
{
    Task<List<LanguageDto>> GetAllLanguagesAsync();
    Task<LanguageDto> GetByIdAsync(int id);
    Task Add(AddLanguageDto addLanguageDto);
    Task Update(UpdateLanguageDto updateLanguageDto);
    Task Delete(int id);
}