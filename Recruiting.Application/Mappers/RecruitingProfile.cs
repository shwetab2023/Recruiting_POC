using AutoMapper;
using Recruiting.Application.Dtos;
using Recruiting.Domain.Entities;

namespace Recruiting.Application.Mappers;

public class RecruitingProfile : Profile
{
    public RecruitingProfile()
    {
        CreateMap<AddProfileDto, ProfileDto>();
        CreateMap<ProfileDto, AddProfileDto>();
        CreateMap<AddProfileDto, UserProfile>();
        CreateMap<UserProfile, AddProfileDto>();
    }
}
