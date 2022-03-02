﻿using System;
using System.Collections.Generic;
using data = BE.DAL.DO.Objetos;
using dal = BE.DAL;
using System.Threading.Tasks;
using BE.DAL.DO;
using BE.DAL.EF;

namespace BE.BS
{
    public class Categories : ICRUD<data.Categories>
    {
        private dal.Categories _dal;
        public Categories(NDbContext dbContext)
        {
            _dal = new dal.Categories(dbContext);
        }
        public void Commit(data.Categories t)
        {
            throw new NotImplementedException();
        }

        public void Delete(data.Categories t)
        {
           _dal.Delete(t);
        }

        public IEnumerable<data.Categories> GetAll()
        {
            _dal.GetAll();
        }

        public Task<IEnumerable<data.Categories>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<data.Categories> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public data.Categories GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public void Insert(data.Categories t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Categories t)
        {
            _dal.Update(t);
        }
    }
}
