using System.ComponentModel.DataAnnotations.Schema;

namespace APIGenerationProject.DTOs
{
    
        public class CartItemDTO
        {
            public int Id { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }

            [Column(TypeName = "decimal(18,2)")]
            public decimal UnitPrice { get; set; }
            public int CartId { get; set; }
        }

}
