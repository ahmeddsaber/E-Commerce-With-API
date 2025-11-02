using APIGenerationProject.DTOs;
using APIGenerationProject.Repository.Model;
using APIGenerationProject.UnitOfWorks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIGenerationProject.Controllers
{
 
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly UnitOfWork unitOfWork;

        public ProductController(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var products = unitOfWork.ProductRepo.GetAll()
                .Select(p => new ProductDTO
                {
                    Id=p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Stock = p.Stock,
                    CatogeryName = unitOfWork.CatogeryRepo.GetOne(p.CatogeryId)?.Name
                });

            return Ok(products);
        }

        [HttpGet("{Id}")]
        public IActionResult GetProductById(int Id)
        {
            var pro = unitOfWork.ProductRepo.GetOne(Id);
            if (pro == null)
                return NotFound("Product not found");

            var proDTO = new ProductDTO
            {
                Id=pro.Id,
                Name = pro.Name,
                Description = pro.Description,
                Price = pro.Price,
                Stock = pro.Stock,
                CatogeryName = unitOfWork.CatogeryRepo.GetOne(pro.CatogeryId)?.Name
            };

            return Ok(proDTO);
        }

   
        [HttpPost]
        public IActionResult AddOrderItem(OrderItem item)
        {
            // check if product exists
            var product = unitOfWork.ProductRepo.GetOne(item.ProductId);
            if (product == null)
                return BadRequest($"Product with ID {item.ProductId} not found.");

            // check if order exists
            var order = unitOfWork.OrderRepo.GetOne(item.OrderId);
            if (order == null)
            {
                order = new Order
                {
                    OrderDate = DateTime.Now,
                    TotalAmount = 0
                };
                unitOfWork.OrderRepo.Add(order);
                unitOfWork.Save();

                // assign the new order id to the order item
                item.OrderId = order.Id;
            }

            // calculate unit price if not set
            if (item.UnitPrice <= 0)
                item.UnitPrice = product.Price;

            unitOfWork.OrderItemRepo.Add(item);
            unitOfWork.Save();

            // update total order amount
            order.TotalAmount += item.UnitPrice * item.Quantity;
            unitOfWork.OrderRepo.Update(order, order.Id);
            unitOfWork.Save();

            return Ok(item);
        }


        [HttpPut("{Id}")]
        public IActionResult Update(int Id, ProductDTO productDTO)
        {
            var existing = unitOfWork.ProductRepo.GetOne(Id);
            if (existing == null)
                return NotFound("Product not found");

            if (!ModelState.IsValid)
                return BadRequest("Invalid data");

            existing.Name = productDTO.Name;
            existing.Description = productDTO.Description;
            existing.Price = productDTO.Price;
            existing.Stock = productDTO.Stock;

            unitOfWork.ProductRepo.Update(existing ,Id);
            unitOfWork.Save();

            return Ok(existing);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var existing = unitOfWork.ProductRepo.GetOne(Id);
            if (existing == null)
                return NotFound("Product not found");

            unitOfWork.ProductRepo.Delete(Id);
            unitOfWork.Save();

            return NoContent();
        }
    }
}
