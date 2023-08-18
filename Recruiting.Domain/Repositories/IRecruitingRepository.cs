using Recruiting.Domain.Entities;

namespace Recruiting.Domain.Repositories;

public interface IRecruitingRepository
{
    Task<UserProfile> CreateProfileAsync(UserProfile userProfile);
}
