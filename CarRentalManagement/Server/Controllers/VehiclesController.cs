using CarRentalManagement.Server.Repository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VehiclesController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: api/Vehicle
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehicle = await _unitOfWork.Vehicle.GetAll(
                includes: q => q
                .Include(x => x.Make)
                .Include(x => x.Model)
                .Include(x => x.Color));
            return Ok(vehicle);
        }

        // GET: api/Vehicle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
            var vehicle = await _unitOfWork.Vehicle.Get(
                x => x.Id == id,
                includes: q => q
                    .Include(x => x.Make)
                    .Include(x => x.Model)
                    .Include(x => x.Color)
                    .Include(x => x.RentalRecords));

            if (vehicle == null)
            {
                return NotFound();
            }

            return vehicle;
        }

        // PUT: api/Vehicle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }

            // Create image 
            if (vehicle.Image != null)
            {
                vehicle.ImageName = CreateImage(vehicle.Image, vehicle.ImageName);
            }

            _unitOfWork.Vehicle.Update(vehicle);

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
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            // Create image 
            if (vehicle.Image != null)
            {
                vehicle.ImageName = CreateImage(vehicle.Image, vehicle.ImageName);
            }

            await _unitOfWork.Vehicle.Insert(vehicle);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
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
            var vehicle = await _unitOfWork.Vehicle.Get(x => x.Id == id);

            return vehicle != null;
        }

        private string CreateImage(byte[] image, string imageName)
        {
            var url = _httpContextAccessor.HttpContext!.Request.Host.Value;
            var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{imageName}";
            var fileStream = System.IO.File.Create(path);
            fileStream.Write(image, 0, image.Length);
            fileStream.Close();
            return $"https://{url}/uploads/{imageName}";
        }

    }
}
