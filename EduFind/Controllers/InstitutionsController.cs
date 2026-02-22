using EduFind.Models;
using EduFind.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EduFind.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstitutionsController : ControllerBase
    {
        private readonly IInstitutionRepository _repo;

        public InstitutionsController(IInstitutionRepository repo)
        {
            _repo = repo;
        }

        // GET ALL
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repo.GetAllAsync();
            return Ok(data);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _repo.GetByIdAsync(id);
            Console.WriteLine("changes test");
            if (item == null)
                return NotFound();

            return Ok(item);
        }

        // CREATE
        [HttpPost]
        public async Task<IActionResult> Create(Institution institution)
        {
            await _repo.AddAsync(institution);
            return Ok(institution);
        }

        // UPDATE
        [HttpPut]
        public async Task<IActionResult> Update(Institution institution)
        {
            await _repo.UpdateAsync(institution);
            return Ok(institution);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repo.DeleteAsync(id);
            return Ok(id);
        }
    }
}
