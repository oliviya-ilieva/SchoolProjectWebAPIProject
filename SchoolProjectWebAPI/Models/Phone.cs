
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public PhoneCode PhoneCode { get; set; }
        public string? PhoneNumber { get; set; }
        public Student? Student { get; set; }
        public Teacher? Teacher { get; set; }

        
    }
}
