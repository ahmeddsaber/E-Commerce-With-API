using APIGenerationProject.Repository.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIGenerationProject.DTOs
{
    public class CreateOrderItemDTO
    {
        [Required]
        public int Id { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }


        public int OrderId { get; set; }
     

        public int ProductId { get; set; }
    
    }
}
