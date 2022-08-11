using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProjectWebAPI.Dtos;
using SchoolProjectWebAPI.Services;

namespace SchoolProjectWebAPI.Controllers
{
    [Route("api/addresses")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly ISchoolProjectRepository _schoolProjectRepository;
        private readonly IMapper _mapper;


        public AddressesController(ISchoolProjectRepository schoolProjectRepository, IMapper mapper)
        {
            _schoolProjectRepository = schoolProjectRepository ?? throw new ArgumentNullException(nameof(schoolProjectRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressDto>>> GetAddresses(int studentId)
        {
            if (!await _schoolProjectRepository.StudentExistsAsync(studentId))
            {
                return NotFound();
            }

            var addressesForStudent = await _schoolProjectRepository.GetAddressesForStudentAsync(studentId);
            return Ok(_mapper.Map<IEnumerable<AddressDto>>(addressesForStudent));
        }

        [HttpGet("{addressId}", Name = "GetAddress")]
        public async Task<ActionResult<AddressDto>> GetAddress(int studentId, int addressId)
        {
            if (!await _schoolProjectRepository.StudentExistsAsync(studentId))
            {
                return NotFound();
            }

            var address = await _schoolProjectRepository.GetAddressForStudentAsync(studentId, addressId);

            if (address == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<AddressDto>(address));
        }

        [HttpPost] 

        public async Task<ActionResult<AddressDto>> CreateAddress(int studentId, AddressForCreationDto address)
        {
            if (!await _schoolProjectRepository.StudentExistsAsync(studentId))
            {
                return NotFound();
            }

            var finalAddress = _mapper.Map<Models.Address>(address);

            await _schoolProjectRepository.AddAddressForStudentAsync(studentId, finalAddress);

            await _schoolProjectRepository.SaveChangesAsync();

            var createdAddressToReturn = _mapper.Map<Dtos.AddressDto>(finalAddress);

            return CreatedAtRoute("GetAddress", new
            {
                studentId = studentId,
                addressId = createdAddressToReturn.Id
            },
            createdAddressToReturn);
        }


        [HttpPut("{addressId}")]

        public async Task<ActionResult<AddressDto>> UpdateAddress(int studentId, int addressId, AddressForUpdateDto address)
        {
            if (!await _schoolProjectRepository.StudentExistsAsync(studentId))
            {
                return NotFound();
            }

            var addressEntity = await _schoolProjectRepository.GetAddressForStudentAsync(studentId, addressId);

            if (addressEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(address, addressEntity);

            await _schoolProjectRepository.SaveChangesAsync();

            return NoContent();
        }

            [HttpDelete("{addressId}")]

            public async Task<ActionResult> DeleteAddress(int studentId, int addressId)
            {
                if (!await _schoolProjectRepository.StudentExistsAsync(studentId))
                {
                    return NotFound();
                }
                var addressEntity = await _schoolProjectRepository.GetAddressForStudentAsync(studentId, addressId);
                if (addressEntity == null)
                {
                    return NotFound();
                }
                _schoolProjectRepository.DeleteAddress(addressEntity);
            await _schoolProjectRepository.SaveChangesAsync();

            return NoContent();

            }
        }
    }

