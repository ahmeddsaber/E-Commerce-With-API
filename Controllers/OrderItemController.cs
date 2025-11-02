using APIGenerationProject.DTOs;
using APIGenerationProject.Repository.Model;
using APIGenerationProject.UnitOfWorks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace APIGenerationProject.Controllers
{
    [Authorize("Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public OrderItemController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/OrderItem
        [HttpGet]
        public IActionResult GetAllOrderItems()
        {
            var items = _unitOfWork.OrderItemRepo.GetAll();

            var itemsDto = items.Select(i => new OrderItemDTO
            {
                Id = i.Id,
                Quantity = i.Quantity,
                UnitPrice = i.UnitPrice,
                OrderId = i.OrderId,
                ProductId = i.ProductId
            }).ToList();

            return Ok(itemsDto);
        }

        // GET: api/OrderItem/5
        [HttpGet("{id}")]
        public IActionResult GetOrderItem(int id)
        {
            var item = _unitOfWork.OrderItemRepo.GetOne(id);
            if (item == null) return NotFound($"Order item with ID {id} not found.");

            var itemDto = new OrderItemDTO
            {
                Id = item.Id,
                Quantity = item.Quantity,
                UnitPrice = item.UnitPrice,
                OrderId = item.OrderId,
                ProductId = item.ProductId
            };

            return Ok(itemDto);
        }

        // POST: api/OrderItem
        [HttpPost]
        public IActionResult AddOrderItem(OrderItemDTO itemDto)
        {
            var item = new OrderItem
            {
                Quantity = itemDto.Quantity,
                UnitPrice = itemDto.UnitPrice,
                OrderId = itemDto.OrderId,
                ProductId = itemDto.ProductId
            };

            _unitOfWork.OrderItemRepo.Add(item);
            _unitOfWork.Save();


            itemDto.Id = item.Id;
            return Ok(itemDto);
        }

        // PUT: api/OrderItem/5
        [HttpPut("{id}")]
        public IActionResult UpdateOrderItem(int id, OrderItemDTO itemDto)
        {
            var existingItem = _unitOfWork.OrderItemRepo.GetOne(id);
            if (existingItem == null) return NotFound($"Order item with ID {id} not found.");

            existingItem.Quantity = itemDto.Quantity;
            existingItem.UnitPrice = itemDto.UnitPrice;
            existingItem.OrderId = itemDto.OrderId;
            existingItem.ProductId = itemDto.ProductId;

            _unitOfWork.OrderItemRepo.Update(existingItem, id);
            _unitOfWork.Save();

            return Ok(itemDto);
        }

        // DELETE: api/OrderItem/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderItem(int id)
        {
            var existingItem = _unitOfWork.OrderItemRepo.GetOne(id);
            if (existingItem == null) return NotFound($"Order item with ID {id} not found.");

            _unitOfWork.OrderItemRepo.Delete(id);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}
