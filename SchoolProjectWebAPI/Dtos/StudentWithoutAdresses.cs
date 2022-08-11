using SchoolProjectWebAPI.Models;

namespace SchoolProjectWebAPI.Dtos
{
    public class StudentWithoutAdresses
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = string.Empty;
        public string SSN { get; set; } = null!;
        public Sex Sex { get; set; }

        public Grade Grade { get; set; }

        public ClassLetter ClassLetter { get; set; }


    }
}
