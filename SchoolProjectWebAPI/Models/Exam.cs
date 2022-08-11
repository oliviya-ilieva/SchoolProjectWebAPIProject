
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Type { get; set; }
        public DateTime Date { get; set; }
   
        public List<Result>? Result { get; set; }
        public Teacher? Teacher { get; set; }
        public Subject Subject { get; set; } 
    }
}
