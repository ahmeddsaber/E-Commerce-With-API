using APIGenerationProject.Repository.Model;

namespace APIGenerationProject.GenericRepository
{
    public class GenericCatogery
    {
        GenericRepository <Catogery> repository;
        public GenericCatogery(GenericRepository<Catogery> repository)
        {
            this.repository = repository;
            
        }
        public List<Catogery> GetAllCatoeries() {
            return repository.GetAll();

        
        }
        public Catogery GetCatogery(int id) {
        
        return repository.GetOne(id);
                }

        public void  Add( Catogery catogery)
        {
            repository.Add(catogery);
        }
        public void update (Catogery catogery , int Id)
        {
            repository.Update(catogery , Id);
        }
        public void DeleteCatogery(int id ) { 
            repository.Delete(id);
        
        }




    }
}
