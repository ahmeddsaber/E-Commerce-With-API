using APIGenerationProject.DTOs;
using APIGenerationProject.Repository.Model;
using APIGenerationProject.UnitOfWorks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace APIGenerationProject.Controllers
{    [Authorize ("Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public OrderController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Order
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var orders = _unitOfWork.OrderRepo.GetAll();

            var ordersDto = orders.Select(o => new CreateOrderDTO
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                TotalAmount = o.TotalAmount,
                OrderItems = o.OrderItems.Select(oi => new OrderItemDTO
                {
                    Id = oi.Id,
                    ProductId = oi.ProductId,
                    Quantity = oi.Quantity,
                    UnitPrice = oi.UnitPrice
                }).ToList()
            }).ToList();

            return Ok(ordersDto);
        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var order = _unitOfWork.OrderRepo.GetOne(id);
            if (order == null) return NotFound($"Order with ID {id} not found.");

            var orderDto = new CreateOrderDTO
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                OrderItems = order.OrderItems.Select(oi => new OrderItemDTO
                {
                    Id = oi.Id,
                    ProductId = oi.ProductId,
                    Quantity = oi.Quantity,
                    UnitPrice = oi.UnitPrice
                }).ToList()
            };

            return Ok(orderDto);
        }

        // POST: api/Order
        [HttpPost]
        public IActionResult AddOrder(CreateOrderDTO orderDto)
        {
            var order = new Order
            {
                OrderDate = orderDto.OrderDate,
                TotalAmount = orderDto.TotalAmount,
                OrderItems = orderDto.OrderItems.Select(oi => new OrderItem
                {
                    ProductId = oi.ProductId,
                    Quantity = oi.Quantity,
                    UnitPrice = oi.UnitPrice
                }).ToList()
            };

            _unitOfWork.OrderRepo.Add(order);
            _unitOfWork.Save();

            orderDto.Id = order.Id; // نرجع الـ Id بعد الإضافة
            return Ok(orderDto);
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, CreateOrderDTO orderDto)
        {
            var existingOrder = _unitOfWork.OrderRepo.GetOne(id);
            if (existingOrder == null) return NotFound($"Order with ID {id} not found.");

            existingOrder.OrderDate = orderDto.OrderDate;
            existingOrder.TotalAmount = orderDto.TotalAmount;

            // تحديث العناصر
            existingOrder.OrderItems.Clear();
            existingOrder.OrderItems = orderDto.OrderItems.Select(oi => new OrderItem
            {
                ProductId = oi.ProductId,
                Quantity = oi.Quantity,
                UnitPrice = oi.UnitPrice
            }).ToList();

            _unitOfWork.OrderRepo.Update(existingOrder, id);
            _unitOfWork.Save();

            return Ok(orderDto);
        }

        // DELETE: api/Order/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var existingOrder = _unitOfWork.OrderRepo.GetOne(id);
            if (existingOrder == null) return NotFound($"Order with ID {id} not found.");

            _unitOfWork.OrderRepo.Delete(id);
            _unitOfWork.Save();
            return NoContent();
        }
    }
}
