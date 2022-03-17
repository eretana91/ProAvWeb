using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.DO;
using DAL.DO.Interfaces;
using DAL.EF;
using DAL.Repository;
using data = DAL.DO.Objects;

namespace DAL
{
    public class CustomerCustomerDemo : ICRUD<data.CustomerCustomerDemo>
    {
        private RepositoryCustomerCustomerDemo repo;
        public CustomerCustomerDemo(NDbContext dbContext)
        {
            repo = new RepositoryCustomerCustomerDemo(dbContext);
        }
        public void Commit(data.CustomerCustomerDemo t)
        {
            throw new NotImplementedException();
        }

        public void Delete(data.CustomerCustomerDemo t)
        {
            repo.Delete(t);
            repo.Commit(t);
        }

        public IEnumerable<data.CustomerCustomerDemo> GetAll()
        {
            return repo.Getall();
        }

        public Task<IEnumerable<data.CustomerCustomerDemo>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public Task<data.CustomerCustomerDemo> GetOneByIdAsync(int id)
        {
            return null;
        }

        public Task<data.CustomerCustomerDemo> GetOneByIdAsync(string CustomerId, string CustomerTyperId)
        {
            return repo.GetOneByIdAsync(CustomerId,CustomerTyperId);
        }

        public data.CustomerCustomerDemo GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public void Insert(data.CustomerCustomerDemo t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.CustomerCustomerDemo t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
