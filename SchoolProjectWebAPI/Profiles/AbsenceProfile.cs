using AutoMapper;

namespace SchoolProjectWebAPI.Profiles
{
    public class AbsenceProfile : Profile
    {
        public AbsenceProfile()
        {
            CreateMap<Models.Absence, Dtos.AbsenceDto>();
            CreateMap<Dtos.AbsenceForCreationDto, Models.Absence>();
        }
    }
}
