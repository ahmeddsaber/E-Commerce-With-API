using System.ComponentModel.DataAnnotations.Schema;

namespace APIGenerationProject.Repository.Model
{
    public class OrderItem : BaseEnity
    {
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

