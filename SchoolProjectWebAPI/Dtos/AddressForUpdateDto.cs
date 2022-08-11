using SchoolProjectWebAPI.Models;

namespace SchoolProjectWebAPI.Dtos
{
    public class AddressForUpdateDto
    {
        public string Street { get; set; } = null!;
        public ZipCode ZipCode { get; set; }
        public string? City { get; set; }
    }
}
