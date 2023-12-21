using BusnissLogicLayer.Interfaces;
using BussnisLogicLayer.Extended;
using DTOAccessLayer.Dtos.EducationDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OneApply.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EducationController(IEducatonService educatonService) : ControllerBase
{
    private readonly IEducatonService _educatonService = educatonService;

    [HttpGet("get")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var educations = await _educatonService.GetAllAsync();
            return Ok(educations);
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
            var educatioin = await _educatonService.GetByIdAsync(id);
            return Ok(educatioin);
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

    [HttpGet("paged")]
    public async Task<IActionResult> Get(int pageSize = 10, int pageNumber = 1)
    {
        try
        {
            var educations = await _educatonService.GetAllPagedAsync(pageSize, pageNumber);
            return Ok(educations);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post(AddEducationDto educationDto)
    {
        try
        {
            await _educatonService.Add(educationDto);
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
    public async Task<IActionResult> Put(UpdateEducationDto dto)
    {
        try
        {
            await _educatonService.Update(dto);
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
            await _educatonService.Delete(id);
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
