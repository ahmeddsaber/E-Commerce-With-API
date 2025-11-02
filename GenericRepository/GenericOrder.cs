using APIGenerationProject.Repository.Model;

namespace APIGenerationProject.GenericRepository
{
    public class GenericOrder
    {
        private readonly GenericRepository<Order> repository;

        public GenericOrder(GenericRepository<Order> repository)
        {
            this.repository = repository;
        }

        public List<Order> GetAllOrders()
        {
            return repository.GetAll();
        }

        public Order GetOrder(int id)
        {
            return repository.GetOne(id);
        }

        public void Add(Order order)
        {
            repository.Add(order);
        }

        public void Update(Order order, int id)
        {
            repository.Update(order, id);
        }

        public void DeleteOrder(int id)
        {
            repository.Delete(id);
        }
    }
}
