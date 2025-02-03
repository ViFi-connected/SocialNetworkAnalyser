using AutoMapper;
using SocialNetworkAnalyser.Data.Entities;
using SocialNetworkAnalyser.Shared.Dtos;

namespace SocialNetworkAnalyser.Shared
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