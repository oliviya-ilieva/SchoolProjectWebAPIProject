
using Microsoft.EntityFrameworkCore;
using SchoolProjectWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSchoolProject.Data
{
    public class SchoolProjectContext : DbContext
    {
      

        public SchoolProjectContext(DbContextOptions<SchoolProjectContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<EmailAddress> EmailAddresses { get; set; } = null!;
        public DbSet<Phone> Phones { get; set; } = null!;
        public DbSet<Absence> Absences { get; set; } = null!;
        public DbSet<Exam> Exams { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Result> Results { get; set; } = null!;
        public DbSet<Remark> Remarks { get; set; } = null!;

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Peter",
                    LastName = "Stotanov",
                    SSN = "9806543",
                    Grade = Grade.Second,
                    ClassLetter = ClassLetter.C,
                   /* Addresses = new List<Address>
                    {
                     new Address { Id = 5, ZipCode = ZipCode.Vratsa,   }
                    }*/
                },
                 new Student
                 {
                     Id = 2,
                     FirstName = "Eleonora",
                     LastName = "Dimitrova",
                     SSN = "98765798",
                     Grade = Grade.Second,
                     ClassLetter = ClassLetter.C
                 },
                  new Student
                  {
                      Id = 3,
                      FirstName = "Dimitar",
                      LastName = "Ivanov",
                      SSN = "9876609",
                      Grade = Grade.Third,
                      ClassLetter = ClassLetter.D
                  },
                    new Student
                    {
                        Id = 4,
                        FirstName = "Stoyan",
                        LastName = "Todorov",
                        SSN = "98766876",
                        Grade = Grade.Fourth,
                        Sex = Sex.Male,
                        ClassLetter = ClassLetter.F
                    },
                     new Student
                     {
                         Id = 6,
                         FirstName = "Stoyan",
                         LastName = "Todorov",
                         SSN = "9876689",
                         Grade = Grade.Eleventh,
                         Sex = Sex.Male,
                         ClassLetter = ClassLetter.F,
                      
                     }

                );
            modelBuilder.Entity<Address>().HasData(
               new Address
               {
                   Id = 2,
                   Street = "Slivnitsa",
                   ZipCode = ZipCode.Sofia,
                   StudentId = 3
               },
                  new Address
                  {
                      Id = 3,
                      Street = "Smirnenski",
                      ZipCode = ZipCode.Sofia,
                      StudentId = 3,
                      TeacherId = 2
                  }

               );

            base.OnModelCreating(modelBuilder);
        }


    }
}
