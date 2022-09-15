using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhiteVilla_VillaAPI.Data;
using WhiteVilla_VillaAPI.Models;
using WhiteVilla_VillaAPI.Models.DTO;

namespace WhiteVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public VillaAPIController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        /*private readonly ILogger<VillaAPIController> _logger;

        public VillaAPIController(ILogger<VillaAPIController> logger)
        {
            _logger = logger;
        }*/

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        {
            //_logger.LogInformation("Getting All Villas");

            IEnumerable<Villa> villaList = await _db.Villas.ToListAsync();
            return Ok(_mapper.Map<List<VillaDTO>>(villaList));

            //return Ok(await _db.Villas.ToListAsync()); без AutoMappera
        }


        [HttpGet("{id:int}", Name = "GetVilla")]
        //[HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
        public async Task<ActionResult<VillaDTO>> GetVillaById(int id)
        {
            if (id == 0)
            {
                //_logger.LogError("Can not found villa with id " + id);
                return BadRequest();
            }

            var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            //return VillaStore.villaList[id];

            return Ok(_mapper.Map<VillaDTO>(villa));

            //return Ok(villa); без AutoMappera
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (await _db.Villas.FirstOrDefaultAsync(u => u.Name.ToLower() == createDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Villa Already Exists!");
                return BadRequest(ModelState);
            }

            if (createDTO == null)
            {
                return BadRequest(createDTO);
            }
            /*if (villaDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }*/


            /*Villa model = new()                             без AutoMappera
            {
                Amenity = createDTO.Amenity,
                Details = createDTO.Details,
                ImgUrl = createDTO.ImgUrl,
                Name = createDTO.Name,
                Occupancy = createDTO.Occupancy,
                Rate = createDTO.Rate,
                Sqft = createDTO.Sqft
            };*/

            Villa model = _mapper.Map<Villa>(createDTO);

            await _db.Villas.AddAsync(model);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetVilla", new { id = model.Id }, model);
        }


        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            _db.Villas.Remove(villa);
            await _db.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            if (updateDTO == null || id != updateDTO.Id)
            {
                return BadRequest();
            }

            /*var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            villa.Name = villaDTO.Name;
            villa.Occupancy = villaDTO.Occupancy;
            villa.Sqft = villaDTO.Sqft;*/

            /*Villa model= new()                        без AutoMappera
            {
                Amenity = updateDTO.Amenity,
                Details = updateDTO.Details,
                Id = updateDTO.Id,
                ImgUrl = updateDTO.ImgUrl,
                Name = updateDTO.Name,
                Occupancy = updateDTO.Occupancy,
                Rate = updateDTO.Rate,
                Sqft = updateDTO.Sqft
            };*/

            Villa model = _mapper.Map<Villa>(updateDTO);

            _db.Villas.Update(model);
            await _db.SaveChangesAsync();
            
            return NoContent();
        }



        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var villa = await _db.Villas.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);

            VillaUpdateDTO villaDTO = _mapper.Map<VillaUpdateDTO>(villa);

            /*VillaUpdateDTO villaDTO = new()                без AutoMappera
            {
                Amenity = villa.Amenity,
                Details = villa.Details,
                Id = villa.Id,
                ImgUrl = villa.ImgUrl,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Sqft = villa.Sqft
            };*/

            if (villa == null)
            {
                return BadRequest();
            }
            patchDTO.ApplyTo(villaDTO, ModelState);

            Villa model = _mapper.Map<Villa>(villaDTO);

            /*Villa model = new()
            {
                Amenity = villaDTO.Amenity,
                Details = villaDTO.Details,
                Id = villaDTO.Id,
                ImgUrl = villaDTO.ImgUrl,
                Name = villaDTO.Name,
                Occupancy = villaDTO.Occupancy,
                Rate = villaDTO.Rate,
                Sqft = villaDTO.Sqft
            };*/

            _db.Villas.Update(model);
            await _db.SaveChangesAsync();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }


    }
}