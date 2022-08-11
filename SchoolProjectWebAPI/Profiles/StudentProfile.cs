using AutoMapper;



namespace SchoolProjectWebAPI.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Models.Student, Dtos.StudentWithoutAdresses>();
            CreateMap<Models.Student, Dtos.StudentDto>();
          
        }
    }
}
