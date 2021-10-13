using CarRentalManagement.Server.Repository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Vehicle
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Vehicle = await _unitOfWork.Vehicle.GetAll();
            return Ok(Vehicle);
        }

        // GET: api/Vehicle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
            var Vehicle = await _unitOfWork.Vehicle.Get(x => x.Id == id);

            if (Vehicle == null)
            {
                return NotFound();
            }

            return Vehicle;
        }

        // PUT: api/Vehicle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle Vehicle)
        {
            if (id != Vehicle.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Vehicle.Update(Vehicle);

            try
            {
                await _unitOfWork.Save(this.HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
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

        // POST: api/Vehicle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle Vehicle)
        {
            await _unitOfWork.Vehicle.Insert(Vehicle);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetVehicle", new { id = Vehicle.Id }, Vehicle);
        }

        // DELETE: api/Vehicle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            if (!await VehicleExists(id))
            {
                return NotFound();
            }

            await _unitOfWork.Vehicle.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            var Vehicle = await _unitOfWork.Vehicle.Get(x => x.Id == id);

            return Vehicle != null;
        }
    }
}
