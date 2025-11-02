using APIGenerationProject.Repository.Model;

namespace APIGenerationProject.GenericRepository
{
    public class GenericOrderItem
    {
        private readonly GenericRepository<OrderItem> repository;

        public GenericOrderItem(GenericRepository<OrderItem> repository)
        {
            this.repository = repository;
        }

        public List<OrderItem> GetAllOrderItems()
        {
            return repository.GetAll();
        }

        public OrderItem GetOrderItem(int id)
        {
            return repository.GetOne(id);
        }

        public void Add(OrderItem orderItem)
        {
            repository.Add(orderItem);
        }

        public void Update(OrderItem orderItem, int id)
        {
            repository.Update(orderItem, id);
        }

        public void DeleteOrderItem(int id)
        {
            repository.Delete(id);
        }
    }
}

