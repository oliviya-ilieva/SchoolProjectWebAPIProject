

using SchoolProjectWebAPI.Models;

namespace SchoolProjectWebAPI.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = string.Empty;
        public string SSN { get; set; } = null!;
        public Sex Sex { get; set; }

        
        public int NumberOfAddresses
        {
            get
            {
                return Addresses.Count;
            }
        }

        public int NumberOfPhones
        {
            get
            {
                return Phones.Count;
            }
        }


        public List<AddressDto> Addresses { get; set; } = new List<AddressDto>();
        public List<PhoneDto> Phones { get; set; } = new List<PhoneDto>();

    }
}
