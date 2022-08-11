
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class Remark
    {
        public int Id { get; set; }

        public string? StudentRemark { get; set; } 

        public Subject Subject { get; set; }

        public Teacher Teacher { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}
