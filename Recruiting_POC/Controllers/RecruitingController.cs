using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Recruiting.Application.Dtos;
using Recruiting.Application.Services;
using Recruiting.Application.Validators;
using System.ComponentModel.DataAnnotations;

namespace Recruiting.API.Controllers;

[Route($"api/[controller]")]
[ApiController]
public class RecruitingController : ControllerBase
{
    private readonly IValidator<AddProfileDto> _validator;
    private readonly IRecruitingService _recruitingService;

    public RecruitingController(IValidator<AddProfileDto> validator, IRecruitingService recruitingService)
    {
        _validator = validator;
        _recruitingService = recruitingService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserProfile([FromBody] AddProfileDto addProfileDto)
    {
        try
        {
            var validationResult = _validator.Validate(addProfileDto);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }
            var userProfile = await _recruitingService.CreateProfileAsync(addProfileDto);

            return Ok(userProfile);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(ex.Message);
        }
    }
}
