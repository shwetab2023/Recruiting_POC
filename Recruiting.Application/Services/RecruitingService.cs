using AutoMapper;
using Recruiting.Application.Dtos;
using Recruiting.Domain.Entities;
using Recruiting.Domain.Repositories;

namespace Recruiting.Application.Services;

public class RecruitingService : IRecruitingService
{
    private readonly IRecruitingRepository _recruitingRepository;
    private readonly IMapper _mapper;

    public RecruitingService(IRecruitingRepository recruitingRepository, IMapper mapper)
    {
        _recruitingRepository = recruitingRepository;
        _mapper = mapper;
    }

    public async Task<ProfileDto> CreateProfileAsync(AddProfileDto profile)
    {
        if (profile == null) { throw new ArgumentNullException(nameof(AddProfileDto)); }

        var userProfile = _mapper.Map<UserProfile>(profile);
        var result = await _recruitingRepository.CreateProfileAsync(userProfile);
        return _mapper.Map<ProfileDto>(result);
    }
}
