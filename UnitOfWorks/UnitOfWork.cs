using APIGenerationProject.Context;
using APIGenerationProject.GenericRepository;
using APIGenerationProject.Repository.Model;

namespace APIGenerationProject.UnitOfWorks
{
    public class UnitOfWork
    {
        private readonly ProjectContext ProjectContext;

        private GenericRepository<Catogery> CatogeryRepository;
        private GenericRepository<Product> ProductRepository;
        private GenericRepository<Order> OrderRepository;
        private GenericRepository<OrderItem> OrderItemRepository;
        private GenericRepository<Cart> CartRepository;
        private GenericRepository<CartItem> CartItemRepository;

        public UnitOfWork(ProjectContext projectContext)
        {
            this.ProjectContext = projectContext;
        }

       
        public GenericRepository<Catogery> CatogeryRepo
        {
            get
            {
                if (this.CatogeryRepository == null)
                {
                    CatogeryRepository = new GenericRepository<Catogery>(ProjectContext);
                }
                return CatogeryRepository;
            }
        }

        public GenericRepository<Product> ProductRepo
        {
            get
            {
                if (this.ProductRepository == null)
                {
                    ProductRepository = new GenericRepository<Product>(ProjectContext);
                }
                return ProductRepository;
            }
        }

 
        public GenericRepository<Order> OrderRepo
        {
            get
            {
                if (this.OrderRepository == null)
                {
                    OrderRepository = new GenericRepository<Order>(ProjectContext);
                }
                return OrderRepository;
            }
        }

    
        public GenericRepository<OrderItem> OrderItemRepo
        {
            get
            {
                if (this.OrderItemRepository == null)
                {
                    OrderItemRepository = new GenericRepository<OrderItem>(ProjectContext);
                }
                return OrderItemRepository;
            }
        }

        public GenericRepository<Cart> CartRepo
        {
            get
            {
                if (this.CartRepository == null)
                {
                    CartRepository = new GenericRepository<Cart>(ProjectContext);
                }
                return CartRepository;
            }
        }

        
        public GenericRepository<CartItem> CartItemRepo
        {
            get
            {
                if (this.CartItemRepository == null)
                {
                    CartItemRepository = new GenericRepository<CartItem>(ProjectContext);
                }
                return CartItemRepository;
            }
        }

       
        public void Save()
        {
            ProjectContext.SaveChanges();
        }
    }
}
