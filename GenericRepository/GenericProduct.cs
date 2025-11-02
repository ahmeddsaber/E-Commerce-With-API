using APIGenerationProject.Repository.Model;

namespace APIGenerationProject.GenericRepository
{
    public class ProductRepository
    {
        private readonly GenericRepository<Product> _genericProduct;

        public ProductRepository(GenericRepository<Product> genericProduct)
        {
            _genericProduct = genericProduct;
        }

        public List<Product> GetAllProducts()
        {
            return _genericProduct.GetAll();
        }

        public Product GetById(int id)
        {
            return _genericProduct.GetOne(id);
        }

        public void Add(Product product)
        {
            _genericProduct.Add(product);
            _genericProduct.Save();
        }

        public void Update(Product product , int Id)
        {
            _genericProduct.Update(product, Id);
           
        }

        public void Delete(int id)
        {
            _genericProduct.Delete(id);

        }
    }
}
