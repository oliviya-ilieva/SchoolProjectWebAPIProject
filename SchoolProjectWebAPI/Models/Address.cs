
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectWebAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; } = null!;
        public ZipCode ZipCode { get; set; }
        public string? City { get; set; }

        [ForeignKey("TeacherId")]
        public Teacher? Teacher  { get; set; }

        public int? TeacherId { get; set; } 

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        public int? StudentId { get; set; }

    }
}