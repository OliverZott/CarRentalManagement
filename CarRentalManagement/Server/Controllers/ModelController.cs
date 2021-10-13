using CarRentalManagement.Server.Repository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<ModelController>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var model = await _unitOfWork.Model.GetAll();
            return Ok(model);
        }

        // GET api/<ModelController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Model>> Get(int id)
        {
            var model = await _unitOfWork.Model.Get(x => x.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        // POST api/<ModelController>
        [HttpPost]
        public async Task<ActionResult<Model>> Post(Model model)
        {
            await _unitOfWork.Model.Insert(model);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("Get", new { id = model.Id }, model);
        }

        // PUT api/<ModelController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Model.Update(model);

            try
            {
                await _unitOfWork.Save(this.HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ModelExists(id))
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

        // DELETE api/<ModelController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!await ModelExists(id))
            {
                return NotFound();
            }

            await _unitOfWork.Color.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> ModelExists(int id)
        {
            var color = await _unitOfWork.Model.Get(x => x.Id == id);

            return color != null;
        }

    }
}
