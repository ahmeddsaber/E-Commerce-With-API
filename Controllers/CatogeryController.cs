using APIGenerationProject.DTOs;
using APIGenerationProject.Repository.Model;
using APIGenerationProject.UnitOfWorks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIGenerationProject.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CatogeryController : ControllerBase 
    {
        private readonly UnitOfWork unitOfWork;

        public CatogeryController(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

       
        [HttpGet]
        public IActionResult ShowAllCatogeries()
        {
            var categories = unitOfWork.CatogeryRepo.GetAll()
                .Select(c => new CatogeryDTO
                {
                    Name = c.Name,
                    Description = c.Description
                });

            return Ok(categories);
        }

        // GET: api/Catogery/5
        [HttpGet("{id}")]
        public IActionResult ShowCatogery(int id)
        {
            var category = unitOfWork.CatogeryRepo.GetOne(id);
            if (category == null)
            {
                return NotFound($"Category with Id {id} not found");
            }

            var categoryDTO = new CatogeryDTO
            {
                Name = category.Name,
                Description = category.Description
            };

            return Ok(categoryDTO);
        }


        [HttpPost]
        [Authorize("Admin")]
        public IActionResult Add(CreateCatogeryDTO createCatogeryDTO)
        {
            var newCategory = new Catogery
            {
                Name = createCatogeryDTO.Name,
                Description = createCatogeryDTO.Description
            };

            unitOfWork.CatogeryRepo.Add(newCategory);
            unitOfWork.CatogeryRepo.Save();
            return Ok(newCategory);
        }

        [Authorize("Admin")]
        [HttpPut("{id}")]
        public IActionResult Update(int id, CatogeryDTO catogeryDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = unitOfWork.CatogeryRepo.GetOne(id);
            if (existing == null)
                return NotFound($"Category with Id {id} not found");

            existing.Name = catogeryDTO.Name;
            existing.Description = catogeryDTO.Description;

            unitOfWork.CatogeryRepo.Update(existing, id);
            unitOfWork.CatogeryRepo.Save();

            return Ok(existing);
        }

   
        [HttpDelete("{id}")]
        [Authorize("Admin")]
        public IActionResult Delete(int id)
        {
            var existing = unitOfWork.CatogeryRepo.GetOne(id);
            if (existing == null)
                return NotFound($"Category with Id {id} not found");

            unitOfWork.CatogeryRepo.Delete(id);
            unitOfWork.CatogeryRepo.Save();

            return NoContent();
        }
    }
}
