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
    public class Customers : ICRUD<data.Customers>
    {
        private dal.Customers _dal;
        public Customers(NDbContext dbContext)
        {
            _dal = new dal.Customers(dbContext);
        }
        public void Commit(data.Customers t)
        {
            throw new NotImplementedException();
        }

        public void Delete(data.Customers t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Customers> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Customers>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.Customers GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Customers> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
        }

        public void Insert(data.Customers t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Customers t)
        {
            _dal.Update(t);
        }
    }
}
