using CarRentalManagement.Server.Repository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customer = await _unitOfWork.Customer.GetAll();
            return Ok(customer);
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> Get(int id)
        {
            var customer = await _unitOfWork.Customer.Get(x => x.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Customer.Update(customer);

            try
            {
                await _unitOfWork.Save(this.HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CustomerExists(id))
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

        // POST: api/Customer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            await _unitOfWork.Customer.Insert(customer);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("Get", new { id = customer.Id }, customer);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (!await CustomerExists(id))
            {
                return NotFound();
            }

            await _unitOfWork.Customer.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> CustomerExists(int id)
        {
            var customer = await _unitOfWork.Customer.Get(x => x.Id == id);

            return customer != null;
        }
    }
}
