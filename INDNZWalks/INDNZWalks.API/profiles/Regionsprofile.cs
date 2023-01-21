using AutoMapper;

namespace INDNZWalks.Api.profiles
{
    public class Regionsprofile :Profile
    {
        public Regionsprofile() 
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
               .ReverseMap();
        }
    }
}
