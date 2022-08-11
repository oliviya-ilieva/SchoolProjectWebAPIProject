using AutoMapper;

namespace SchoolProjectWebAPI.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Models.Address, Dtos.AddressDto>();
            CreateMap<Dtos.AddressForCreationDto, Models.Address>();
            CreateMap<Dtos.AddressForUpdateDto, Models.Address>();
        }
    }
}
