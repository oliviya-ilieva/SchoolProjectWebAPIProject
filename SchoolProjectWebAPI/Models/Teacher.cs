
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string SSN { get; set; } = null!;
        public Sex Sex { get; set; }
        public DateTime DateHired { get; set; }
        public decimal? Salary { get; set;  }

        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Exam> Exams { get; set; } = new List<Exam>();
        public List<EmailAddress> EmailAddreses = new List<EmailAddress>();
        public List<Phone> Phones = new List<Phone>();
        public List<Remark> Remarks = new List<Remark>();
        public List<Absence> Absences = new List<Absence>();
    }
}

