using APIGenerationProject.Repository.Model;

namespace APIGenerationProject.GenericRepository
{
    public class GenericCart
    {
        private readonly GenericRepository<Cart> repository;

        public GenericCart(GenericRepository<Cart> repository)
        {
            this.repository = repository;
        }

        public List<Cart> GetAllCarts()
        {
            return repository.GetAll();
        }

        public Cart GetCart(int id)
        {
            return repository.GetOne(id);
        }

        public void Add(Cart cart)
        {
            repository.Add(cart);
        }

        public void Update(Cart cart, int id)
        {
            repository.Update(cart, id);
        }

        public void DeleteCart(int id)
        {
            repository.Delete(id);
        }
    }
}
