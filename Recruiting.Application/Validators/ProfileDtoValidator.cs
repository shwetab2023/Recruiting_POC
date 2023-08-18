using FluentValidation;
using Recruiting.Application.Dtos;

namespace Recruiting.Application.Validators;

public class ProfileDtoValidator : AbstractValidator<AddProfileDto>
{
    public ProfileDtoValidator()
    {
        RuleFor(a => a.Name).NotEmpty().NotNull().WithMessage("Name cannot be empty");
        RuleFor(a => a.School).NotEmpty().NotNull().WithMessage("School cannot be empty");
        RuleFor(a => a.City).NotEmpty().NotNull().WithMessage("City cannot be empty");
        RuleFor(a => a.Age).GreaterThan(18).WithMessage("Age should be greater than 18");
        RuleFor(a => a.Experience).GreaterThan(0).WithMessage("Experience should be greater than 0");
    }
}
