using APIGenerationProject.Repository.Model;

namespace APIGenerationProject.GenericRepository
{
    public class GenericCartItem
    {
        private readonly GenericRepository<CartItem> repository;

        public GenericCartItem(GenericRepository<CartItem> repository)
        {
            this.repository = repository;
        }

        public List<CartItem> GetAllCartItems()
        {
            return repository.GetAll();
        }

        public CartItem GetCartItem(int id)
        {
            return repository.GetOne(id);
        }

        public void Add(CartItem cartItem)
        {
            repository.Add(cartItem);
        }

        public void Update(CartItem cartItem, int id)
        {
            repository.Update(cartItem, id);
        }

        public void DeleteCartItem(int id)
        {
            repository.Delete(id);
        }
    }
}
