using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class EmailAddress
    {
        public int Id { get; set; }
        public string? Email { get; set; } 
        public Student? Student { get; set; }
        public Teacher? Teacher { get; set; }

    }
}
