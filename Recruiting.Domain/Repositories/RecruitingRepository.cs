using Recruiting.Domain.Entities;

namespace Recruiting.Domain.Repositories;

public class RecruitingRepository : IRecruitingRepository
{
    Task<UserProfile> IRecruitingRepository.CreateProfileAsync(UserProfile userProfile)
    {
        throw new NotImplementedException();
    }
}
