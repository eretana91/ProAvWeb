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
    public class Autores : ICRUD<data.Autores>
    {
        private dal.Autores _dal;
        public Autores(NDbContext dbContext)
        {
            _dal = new dal.Autores(dbContext);
        }
        public void Commit(data.Autores t)
        {
            throw new NotImplementedException();
        }

        public void Delete(data.Autores t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Autores> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Autores>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<data.Autores> GetOneByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public data.Autores GetOneById(string id)
        {
            return _dal.GetOneById(id);
        }

        public void Insert(data.Autores t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Autores t)
        {
            _dal.Update(t);
        }
    }
}
