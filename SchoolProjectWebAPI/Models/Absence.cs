
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class Absence
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsAbsent { get; set; }
        public Subject Subject { get; set; }
        public Student Student { get; set; } = null!;
        public Teacher Teacher { get; set; } = null!;

    }
}
