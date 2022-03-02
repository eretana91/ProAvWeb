using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BE.DAL.DO;
using BE.DAL.EF;
using BE.DAL.Repository;
using data = BE.DAL.DO.Objetos;

namespace BE.DAL
{
    public class Products : ICRUD<data.Products>
    {
        private RepositoryProducts repo;
        public Products(NDbContext dbContext) 
        { 
            repo = new RepositoryProducts(dbContext); 
        }
        public void Commit(data.Products t)
        {
            throw new NotImplementedException();
        }

        public void Delete(data.Products t)
        {
            repo.Delete(t);
            repo.Commit(t);
        }

        public IEnumerable<data.Products> GetAll()
        {
            return repo.Getall();
        }

        public Task<IEnumerable<data.Products>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public Task<data.Products> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public data.Products GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public void Insert(data.Products t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Products t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
