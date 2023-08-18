using Recruiting.Application.Dtos;

namespace Recruiting.Application.Services;

public interface IRecruitingService
{
    Task<ProfileDto> CreateProfileAsync(AddProfileDto profile);
}
