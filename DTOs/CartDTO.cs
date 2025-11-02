namespace APIGenerationProject.DTOs
{
    public class CartDTO
    {
    

            public int Id { get; set; }
            public List<CartItemDTO> CartItems { get; set; } = new List<CartItemDTO>();
     
    }
}
