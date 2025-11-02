using System.ComponentModel.DataAnnotations.Schema;

namespace APIGenerationProject.Repository.Model
{
    public class CartItem : BaseEnity
    {
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
