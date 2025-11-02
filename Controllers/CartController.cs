using APIGenerationProject.DTOs;
using APIGenerationProject.Repository.Model;
using APIGenerationProject.UnitOfWorks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace APIGenerationProject.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public CartController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Cart
        [HttpGet]
        public IActionResult GetAllCarts()
        {
            var carts = _unitOfWork.CartRepo.GetAll(includeProperties: "CartItems");

            var cartsDto = carts.Select(c => new CartDTO
            {
                Id = c.Id,
                CartItems = c.CartItems.Select(ci => new CartItemDTO
                {
                    Id = ci.Id,
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity,
                    UnitPrice = ci.UnitPrice,
                    CartId = ci.CartId
                }).ToList()
            }).ToList();

            return Ok(cartsDto);
        }

        // GET: api/Cart/5
        [HttpGet("{id}")]
        public IActionResult GetCartById(int id)
        {
            var cart = _unitOfWork.CartRepo.GetOne(id, includeProperties: "CartItems");
            if (cart == null)
                return NotFound($"Cart with ID {id} not found.");

            var cartDto = new CartDTO
            {
                Id = cart.Id,
                CartItems = cart.CartItems.Select(ci => new CartItemDTO
                {
                    Id = ci.Id,
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity,
                    UnitPrice = ci.UnitPrice,
                    CartId = ci.CartId
                }).ToList()
            };

            return Ok(cartDto);
        }

        // POST: api/Cart
        [HttpPost]
        public IActionResult AddCart(CartDTO cartDto)
        {
            var cart = new Cart
            {
                CartItems = cartDto.CartItems.Select(ci =>
                {
               
                    var product = _unitOfWork.ProductRepo.GetOne(ci.ProductId);
                    if (product == null)
                        throw new Exception($"Product with ID {ci.ProductId} does not exist.");

                    return new CartItem
                    {
                        ProductId = ci.ProductId,
                        Quantity = ci.Quantity,
                        UnitPrice = ci.UnitPrice
                    };
                }).ToList()
            };

            _unitOfWork.CartRepo.Add(cart);
            _unitOfWork.Save();

            cartDto.Id = cart.Id;
            return Ok(cartDto);
        }



        [HttpPut("{id}")]
        public IActionResult UpdateCart(int id, CartDTO cartDto)
        {
            var existingCart = _unitOfWork.CartRepo.GetOne(id, includeProperties: "CartItems");
            if (existingCart == null)
                return NotFound($"Cart with ID {id} not found.");

            existingCart.CartItems.Clear();
            existingCart.CartItems = cartDto.CartItems.Select(ci =>
            {
                var product = _unitOfWork.ProductRepo.GetOne(ci.ProductId);
                if (product == null)
                    throw new Exception($"Product with ID {ci.ProductId} does not exist.");

                return new CartItem
                {
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity,
                    UnitPrice = ci.UnitPrice
                };
            }).ToList();

            _unitOfWork.CartRepo.Update(existingCart, id);
            _unitOfWork.Save();

            return Ok(cartDto);
        }

        // DELETE: api/Cart/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCart(int id)
        {
            var existingCart = _unitOfWork.CartRepo.GetOne(id);
            if (existingCart == null)
                return NotFound($"Cart with ID {id} not found.");

            _unitOfWork.CartRepo.Delete(id);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}
