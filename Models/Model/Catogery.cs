using System.ComponentModel.DataAnnotations.Schema;

namespace APIGenerationProject.Repository.Model
{
    public class Catogery: BaseEnity
    {
     
        public string Name { get; set; } 
        public string Description { get; set; }
    
        


        public int ProductId { get; set; }
        public List<Product>? Products { get; set; }
        //new List<Product>();





    }
}
