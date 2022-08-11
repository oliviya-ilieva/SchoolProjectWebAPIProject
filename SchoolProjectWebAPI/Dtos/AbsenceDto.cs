using SchoolProjectWebAPI.Models;

namespace SchoolProjectWebAPI.Dtos
{
    public class AbsenceDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsAbsent { get; set; }
        public Subject Subject { get; set; }
      
    }
}
