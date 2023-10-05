using AutoMapper;
using CapitalTask_Backend.Dto;
using CapitalTask_Backend.Entities;

namespace CapitalTask_Backend.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CreateMap<SourceType, DestinationType>()

            // This line defines a mapping from ProgramDetailsDto to ProgramDetails
            CreateMap<ProgramDetailsDto, ProgramDetails>();

          
            // This line defines a mapping from UserDto to User
            CreateMap<UserDto, User>();

            
        }
    }
}