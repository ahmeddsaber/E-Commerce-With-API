using APIGenerationProject.DTOs;
using APIGenerationProject.Repository.Model;
using APIGenerationProject.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;

namespace APIGenerationProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartItemController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public CartItemController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // ✅ Get all cart items
        [HttpGet]
        public IActionResult GetAllCartItems()
        {
            var cartItems = _unitOfWork.CartItemRepo.GetAll();
            return Ok(cartItems);
        }

        // ✅ Get cart item by ID
        [HttpGet("{id}")]
        public IActionResult GetCartItemById(int id)
        {
            var cartItem = _unitOfWork.CartItemRepo.GetOne(id);
            if (cartItem == null)
                return NotFound($"Cart item with ID {id} not found.");

            return Ok(cartItem);
        }

        // ✅ Add new cart item
        // إضافة CartItem جديد في Controller
        [HttpPost]
        public IActionResult AddCartItem(CartItemDTO cartItemDto)
        {
            var product = _unitOfWork.ProductRepo.GetOne(cartItemDto.ProductId);
            if (product == null)
                return BadRequest($"Product with ID {cartItemDto.ProductId} does not exist.");

            var cartItem = new CartItem
            {
                ProductId = cartItemDto.ProductId,
                CartId = cartItemDto.CartId,
                Quantity = cartItemDto.Quantity,
                UnitPrice = cartItemDto.UnitPrice
            };

            _unitOfWork.CartItemRepo.Add(cartItem);
            _unitOfWork.Save();

            cartItemDto.Id = cartItem.Id;
            return Ok(cartItemDto);
        }


        // ✅ Update existing cart item
        [HttpPut("{id}")]
        public IActionResult UpdateCartItem(int id, CartItem item)
        {
            var existingItem = _unitOfWork.CartItemRepo.GetOne(id);
            if (existingItem == null)
                return NotFound($"Cart item with ID {id} not found.");

            _unitOfWork.CartItemRepo.Update(item, id);
            _unitOfWork.Save();

            return Ok(item);
        }

        // ✅ Delete cart item
        [HttpDelete("{id}")]
        public IActionResult DeleteCartItem(int id)
        {
            var existingItem = _unitOfWork.CartItemRepo.GetOne(id);
            if (existingItem == null)
                return NotFound($"Cart item with ID {id} not found.");

            _unitOfWork.CartItemRepo.Delete(id);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}
