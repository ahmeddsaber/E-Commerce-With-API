namespace APIGenerationProject.DTOs
{
    public class CreateCartDTO
    {
       
            public int Id { get; set; }
            public List<CartItemDTO> CartItems { get; set; } = new List<CartItemDTO>();
        
    }
}
