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
    public class CustomerDemographics : ICRUD<data.CustomerDemographics>
    {
        private Repository<data.CustomerDemographics> repo;
        public CustomerDemographics(NDbContext dbContext)
        {
            repo = new Repository<data.CustomerDemographics>(dbContext);
        }

        public IEnumerable<data.CustomerDemographics> GetAll()
        {
            return repo.Getall();
        }

        public void Delete(data.CustomerDemographics t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public Task<IEnumerable<data.CustomerDemographics>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<data.CustomerDemographics> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public data.CustomerDemographics GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public void Insert(data.CustomerDemographics t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.CustomerDemographics t)
        {
            repo.Update(t);
            repo.Commit();
        }

        public void Commit(data.CustomerDemographics t)
        {
            throw new NotImplementedException();
        }
    }
}
