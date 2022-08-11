using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProjectWebAPI.Dtos;
using SchoolProjectWebAPI.Services;

namespace SchoolProjectWebAPI.Controllers
{
    [Route("api/students/absences")]
    [ApiController]
    public class AbsencesController : ControllerBase
    {
        private readonly ISchoolProjectRepository _schoolProjectRepository;
        private readonly IMapper _mapper;


        public AbsencesController(ISchoolProjectRepository schoolProjectRepository, IMapper mapper)
        {
            _schoolProjectRepository = schoolProjectRepository ?? throw new ArgumentNullException(nameof(schoolProjectRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<AbsenceDto>> GetAbsence(int studentId, int absenceId)
        {
            if (!await _schoolProjectRepository.StudentExistsAsync(studentId))
            {
                return NotFound();
            }

            var absence = await _schoolProjectRepository.GetStudentAbsencesAsync(studentId, absenceId);

            if (absence == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<AbsenceDto>(absence));
        }

        [HttpPost]

        public async Task<ActionResult<AbsenceDto>> CreateAbsence(int studentId, AbsenceForCreationDto absence)
        {
            if (!await _schoolProjectRepository.StudentExistsAsync(studentId))
            {
                return NotFound();
            }

            var finalAbsence = _mapper.Map<Models.Absence>(absence);

            await _schoolProjectRepository.AddAbsenceForStudentAsync(studentId, finalAbsence);

            await _schoolProjectRepository.SaveChangesAsync();

            var createdAbsenceToReturn = _mapper.Map<Dtos.AbsenceDto>(finalAbsence);

            return CreatedAtRoute("GetAbsence", new
            {
                studentId = studentId,
                absenceId = createdAbsenceToReturn.Id
            },
            createdAbsenceToReturn);
        }
    }
}
