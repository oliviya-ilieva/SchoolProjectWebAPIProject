using AutoMapper;

namespace SchoolProjectWebAPI.Profiles
{
    public class ResultProfile : Profile
    {

        public ResultProfile()
        {
            CreateMap<Models.Result, Dtos.ResultDto>();
            CreateMap<Dtos.ResultForCreationDto, Models.Result>();
        }
       
    }
}
