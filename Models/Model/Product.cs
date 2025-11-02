using System.ComponentModel.DataAnnotations.Schema;

namespace APIGenerationProject.Repository.Model
{
    public class Product:BaseEnity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
       
        public int CatogeryId { get; set; }

        public Catogery Catogery { get; set; }
        //= new Catogery();

    }
}
