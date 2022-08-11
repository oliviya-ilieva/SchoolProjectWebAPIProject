
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class Result
    {
        public int Id { get; set; }
        public Mark Mark { get; set; }
        public string? Description { get; set; }

        public Exam? Exam { get; set; }
        public Student? Student { get; set; }
    }
}
