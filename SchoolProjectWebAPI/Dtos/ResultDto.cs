using SchoolProjectWebAPI.Models;

namespace SchoolProjectWebAPI.Dtos
{
    public class ResultDto
    {
        public int Id { get; set; }
        public Mark Mark { get; set; }
        public string? Description { get; set; }
    }
}
