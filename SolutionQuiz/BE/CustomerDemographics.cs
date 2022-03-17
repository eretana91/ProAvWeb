using System;
using System.Collections.Generic;
using data = DAL.DO.Objects;
using dal = DAL;
using System.Threading.Tasks;
using DAL.DO;
using DAL.EF;
using DAL.DO.Interfaces;

namespace BE
{
    public class CustomerDemographics : ICRUD<data.CustomerDemographics>
    {
        private dal.CustomerDemographics _dal;
        public CustomerDemographics(NDbContext dbContext)
        {
            _dal = new dal.CustomerDemographics(dbContext);
        }
        public void Commit(data.CustomerDemographics t)
        {
            throw new NotImplementedException();
        }

        public void Delete(data.CustomerDemographics t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.CustomerDemographics> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.CustomerDemographics>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.CustomerDemographics GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.CustomerDemographics> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
        }

        public void Insert(data.CustomerDemographics t)
        {
            _dal.Insert(t);
        }

        public void Update(data.CustomerDemographics t)
        {
            _dal.Update(t);
        }
    }
}
