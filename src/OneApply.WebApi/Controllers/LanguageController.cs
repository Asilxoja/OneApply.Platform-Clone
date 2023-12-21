using BusnissLogicLayer.Interfaces;
using BusnissLogicLayer.Services;
using BussnisLogicLayer.Extended;
using DTOAccessLayer.Dtos.EducationDtos;
using DTOAccessLayer.Dtos.LanguageDtos;
using Microsoft.AspNetCore.Mvc;

namespace OneApply.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguageController(ILanguageservice languageservice) : ControllerBase
{
    private readonly ILanguageservice _languageservice = languageservice;

    [HttpGet("get")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var languages = await _languageservice.GetAllLanguagesAsync();
            return Ok(languages);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            var language = await _languageservice.GetByIdAsync(id);
            return Ok(language);
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPost]
    public async Task<IActionResult> Post(AddLanguageDto languageDto)
    {
        try
        {
            await _languageservice.Add(languageDto);
            return Ok("added");
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPut]
    public async Task<IActionResult> Put(UpdateLanguageDto dto)
    {
        try
        {
            await _languageservice.Update(dto);
            return Ok("updated");
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _languageservice.Delete(id);
            return Ok("deleted");
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
