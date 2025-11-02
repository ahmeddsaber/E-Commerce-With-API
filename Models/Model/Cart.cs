namespace APIGenerationProject.Repository.Model
{
    public class Cart : BaseEnity
    {
     

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
