using System.ComponentModel.DataAnnotations.Schema;

namespace APIGenerationProject.Repository.Model
{
    public class Order : BaseEnity
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }

      

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}

