using SchoolProjectWebAPI.Models;

namespace SchoolProjectWebAPI.Dtos
{
    public class AbsenceForCreationDto
    {
       
        public DateTime Date { get; set; }
        public bool IsAbsent { get; set; }
        public Subject Subject { get; set; }
        

    }
}
