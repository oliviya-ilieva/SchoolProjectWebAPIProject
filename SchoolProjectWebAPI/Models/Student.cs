
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string SSN { get; set; } = null!;
        public Sex Sex { get; set; }

        public Grade Grade { get; set; }

        public ClassLetter ClassLetter { get; set; }
        public List<Result> Results { get; set; } = new List<Result>();

        public List<Address> Addresses { get; set; } = new List<Address>();

        public List<EmailAddress> EmailAddreses = new List<EmailAddress>();
        public List<Phone> Phones = new List<Phone>();
        public List<Absence> Absences = new List<Absence>();
        public List<Remark> Remarks = new List<Remark>();


    }
}
