using SchoolProjectWebAPI.Models;

namespace SchoolProjectWebAPI.Dtos
{
    public class PhoneDto
    {
        public int Id { get; set; }
        public PhoneCode PhoneCode { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
