

using SchoolProjectWebAPI.Models;

namespace SchoolProjectWebAPI.Services
{
    public interface ISchoolProjectRepository
    {
        Task<IEnumerable<Student>> GetStudentsAsync();

        Task<Student?> GetStudentAsync(int studentId, bool includeStudentAddresses, bool includeStudentPhones);

        Task<Absence?> GetStudentAbsencesAsync(int studentId, int absenceId);

        Task<bool> StudentExistsAsync(int studentId);

        Task<IEnumerable<Address>> GetAddressesForStudentAsync(int studentId);

        Task<Address?> GetAddressForStudentAsync(int studentId, int addressId);

        Task AddAddressForStudentAsync(int studentId, Address address);

        Task AddAbsenceForStudentAsync(int studentId, Absence absence);

        Task AddResultForStudentAsync(int studentId, Result result);

        void DeleteAddress(Address address);

        Task<bool> SaveChangesAsync();

    }
}
