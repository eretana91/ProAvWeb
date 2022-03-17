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
    public class Customers : ICRUD<data.Customers>
    {
        private Repository<data.Customers> repo;
        public Customers(NDbContext dbContext)
        {
            repo = new Repository<data.Customers>(dbContext);
        }

        public IEnumerable<data.Customers> GetAll()
        {
            return repo.Getall();
        }

        public void Delete(data.Customers t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public Task<IEnumerable<data.Customers>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<data.Customers> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public data.Customers GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public void Insert(data.Customers t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Customers t)
        {
            repo.Update(t);
            repo.Commit();
        }

        public void Commit(data.Customers t)
        {
            throw new NotImplementedException();
        }
    }
}
