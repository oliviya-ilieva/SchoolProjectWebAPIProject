using EfCoreSchoolProject.Data;
using Microsoft.EntityFrameworkCore;
using SchoolProjectWebAPI.Models;
using SchoolProjectWebAPI.Services;

namespace SchoolProjectWebAPI.Services
{
    public class SchoolProjectRepository : ISchoolProjectRepository
    {
        private readonly SchoolProjectContext _context;

        public SchoolProjectRepository(SchoolProjectContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _context.Students.OrderBy(s => s.FirstName).ToListAsync();
        }

        public async Task<Student?> GetStudentAsync(int studentId, bool includeStudentAddresses, bool includeStudentPhones)
        {
            if (includeStudentAddresses)
            {
                return await _context.Students.Include(s => s.Addresses).Where(s => s.Id == studentId).FirstOrDefaultAsync();
            }

            if (includeStudentPhones)
            {
                return await _context.Students.Include(a => a.Phones).Where(a => a.Id == studentId).FirstOrDefaultAsync();
            }

            return await _context.Students.Where(s => s.Id == studentId).FirstOrDefaultAsync();

        }

        public async Task<bool> StudentExistsAsync(int studentId)
        {
            return await _context.Students.AnyAsync(s => s.Id == studentId);
        }

        public async Task<Address?> GetAddressForStudentAsync(int studentId, int addressId)
        {
            
            return await _context.Addresses.Where(a => a.StudentId == studentId && a.Id == addressId).FirstOrDefaultAsync();

        }



        public async Task<IEnumerable<Address>> GetAddressesForStudentAsync(int studentId)
        {
            return await _context.Addresses.Where(a => a.StudentId == studentId).ToListAsync();
        }

        public async Task<Absence?> GetStudentAbsencesAsync(int studentId, int absenceId)
        {
           
            return await _context.Absences.Where(a => a.Id == studentId && a.Id == absenceId).FirstOrDefaultAsync();
        }

        public async Task AddAddressForStudentAsync(int studentId, Address address)
        {
            var student = await GetStudentAsync(studentId, false, false);
            if (student != null)
            {
                student.Addresses.Add(address);
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public async Task AddAbsenceForStudentAsync(int studentId, Absence absence)
        {
            var student = await GetStudentAsync(studentId, false, false);
            if (student != null)
            {
                student.Absences.Add(absence);
            }
        }

        public void DeleteAddress(Address address)
        {
            _context.Addresses.Remove(address);
        }
        public async Task AddResultForStudentAsync(int studentId, Result result)
        {
            var student = await GetStudentAsync(studentId, false, false);
            if (student != null)
            {
                student.Results.Add(result);
            }
        }
    }
}
