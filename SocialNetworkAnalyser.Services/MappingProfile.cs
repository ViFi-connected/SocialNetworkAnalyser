using AutoMapper;
using SocialNetworkAnalyser.Data.Entities;
using SocialNetworkAnalyser.Services.Dtos;

namespace SocialNetworkAnalyser.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dataset, DatasetDto>();
            CreateMap<Friendship, FriendshipDto>();
            CreateMap<Dataset, DatasetStatsDto>();
        }
    }
}