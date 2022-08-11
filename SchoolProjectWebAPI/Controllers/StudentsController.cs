using AutoMapper;
using EfCoreSchoolProject.Data;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SchoolProjectWebAPI.Dtos;
using SchoolProjectWebAPI.Models;
using SchoolProjectWebAPI.Services;

namespace SchoolProjectWebAPI.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ISchoolProjectRepository _schoolProjectRepository;
        private readonly IMapper _mapper;

        public StudentsController(ISchoolProjectRepository schoolProjectRepository, IMapper mapper)
        {
            _schoolProjectRepository = schoolProjectRepository ?? throw new ArgumentNullException(nameof(schoolProjectRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

      /*  [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            var students = await _schoolProjectRepository.GetStudentsAsync();

            var results = new List<Student>();
            return Ok(results);
        }*/

        [HttpGet]
        public async Task<ActionResult<List<StudentWithoutAdresses>>> GetStudents() {

            var studentEntities = await _schoolProjectRepository.GetStudentsAsync();
            return Ok(_mapper.Map<List<StudentWithoutAdresses>>(studentEntities));

            /* var results = new List<StudentWithoutAdresses>();

          foreach (var student in studentEntities)
             {
                 results.Add(new StudentWithoutAdresses {
                     Id = student.Id,
                     FirstName = student.FirstName,
                     LastName = student.LastName,
                     SSN = student.SSN
                 });
             }
 */

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<StudentDto>> GetStudent(int id, bool includeStudentAddresses = false, bool includeStudentPhones = false)
        {
            var student = await _schoolProjectRepository.GetStudentAsync(id, includeStudentAddresses, includeStudentPhones);

            if (student == null)
            {
                return NotFound();
            }

            if (includeStudentAddresses)
            {
                return Ok(_mapper.Map<StudentDto>(student));
            }


            if (includeStudentPhones)
            {
                return Ok(_mapper.Map<StudentDto>(student));
            }

            return Ok(_mapper.Map<StudentWithoutAdresses>(student));
        }

        /*       private readonly SchoolProjectContext _context;

               public SchoolProjectController(SchoolProjectContext context)
               {
                   _context = context;

               }

               [HttpGet("/students")]
               public async Task<ActionResult> GetAllStudents()
               {
                   var students = await _context.Students.ToListAsync();
                   return Ok(students);
               }

              *//* [HttpGet("/students/firstname")]
               public async Task<ActionResult> GetAllStudents(StudentQueryParameters studentQueryparameters)
               {
                   IQueryable<Student> students = _context.Students;
                   if (!string.IsNullOrEmpty(studentQueryparameters.FirstName))
                   {


                       students = students.Where(s => s.FirstName.ToLower().Contains(studentQueryparameters.FirstName.ToLower()));



                   }

                   return Ok(await students.ToArrayAsync());
               }*//*



               [HttpGet("/students/{id}")]
               public async Task<ActionResult> GetStudentById(int id)
               {
                   var student = await _context.Students.FindAsync(id);

                   if (student == null)
                   {
                       return NotFound();

                   }
                   return Ok(student);
               }

               [HttpPost("/student")]
               public async Task<ActionResult<Student>> PostStudent(Student student)
               {
                   _context.Students.Add(student);
                   await _context.SaveChangesAsync();

                   return CreatedAtAction(
                       "GetStudentById",

                       new { id = student.Id },
                       student);
                   }

               [HttpDelete("/students/{id}")]

               public async Task<ActionResult<Student>> DeleteStudent(int id)
               {
                   var student = await _context.Students.FindAsync(id);
                   if (student == null)
                   {
                       return NotFound();

                   }
                   _context.Students.Remove(student);
                   await _context.SaveChangesAsync();

                   return student;

               }


               [HttpPut("/student/{id}")]
               public async Task<ActionResult<Student>> PutStudent(int id, Student student)
               {
                   if (id != student.Id)
                   {
                       return BadRequest();

                   }

                   _context.Entry(student).State = EntityState.Modified;

                   try
                   {
                       await _context.SaveChangesAsync();
                   }
                   catch (DbUpdateConcurrencyException)
                   {
                       if (!_context.Students.Any(s => s.Id == id))
                       {
                           return NotFound();
                       }
                       else
                       {
                           throw;
                       }
                   }
                   return NoContent();
               }

               [HttpPost("/student/result")]
               public async Task<ActionResult<Result>> PostStudentResult(Result result)
               {
                   _context.Results.Add(result);
                   await _context.SaveChangesAsync();

                   return CreatedAtAction(
                       "GetStudentById",

                       new { id = result.Id },
                       result);
               }

               [HttpPost("/exam")]
               public async Task<ActionResult<Exam>> PostExam(Exam exam)
               {
                   _context.Exams.Add(exam);
                   await _context.SaveChangesAsync();

                   return Ok(exam);
               }



               [HttpPost("/teacher")]
               public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
               {
                   _context.Teachers.Add(teacher);
                   await _context.SaveChangesAsync();

                   return Ok(teacher);

               }

               [HttpDelete("/exam/{id}")]

               public async Task<ActionResult<Exam>> DeleteExam(int id)
               {
                   var exam = await _context.Exams.FindAsync(id);
                   if (exam == null)
                   {
                       return NotFound();

                   }
                   _context.Exams.Remove(exam);
                   await _context.SaveChangesAsync();

                   return exam;

               }*/


    }
    }

