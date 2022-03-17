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
    public class CustomerCustomerDemo : ICRUD<data.CustomerCustomerDemo>
    {
        private dal.CustomerCustomerDemo _dal;
        public CustomerCustomerDemo(NDbContext dbContext)
        {
            _dal = new dal.CustomerCustomerDemo(dbContext);
        }
        public void Commit(data.CustomerCustomerDemo t)
        {
            throw new NotImplementedException();
        }

        public void Delete(data.CustomerCustomerDemo t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.CustomerCustomerDemo> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.CustomerCustomerDemo>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.CustomerCustomerDemo GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.CustomerCustomerDemo> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
        }

        public void Insert(data.CustomerCustomerDemo t)
        {
            _dal.Insert(t);
        }

        public void Update(data.CustomerCustomerDemo t)
        {
            _dal.Update(t);
        }
    }
}
