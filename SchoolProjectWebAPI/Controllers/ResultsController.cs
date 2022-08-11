using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProjectWebAPI.Dtos;
using SchoolProjectWebAPI.Services;

namespace SchoolProjectWebAPI.Controllers
{
    [Route("api/students/results")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly ISchoolProjectRepository _schoolProjectRepository;
        private readonly IMapper _mapper;


        public ResultsController(ISchoolProjectRepository schoolProjectRepository, IMapper mapper)
        {
            _schoolProjectRepository = schoolProjectRepository ?? throw new ArgumentNullException(nameof(schoolProjectRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]

        public async Task<ActionResult<ResultDto>> CreateResult(int studentId, ResultForCreationDto result)
        {
            if (!await _schoolProjectRepository.StudentExistsAsync(studentId))
            {
                return NotFound();
            }

            var finalResult = _mapper.Map<Models.Result>(result);

            await _schoolProjectRepository.AddResultForStudentAsync(studentId, finalResult);

            await _schoolProjectRepository.SaveChangesAsync();

            var createdResultToReturn = _mapper.Map<Dtos.ResultDto>(finalResult);

            return CreatedAtRoute("GetResult", new
            {
                studentId = studentId,
                resultId = createdResultToReturn.Id
            },
            createdResultToReturn);
        }

    }
}
