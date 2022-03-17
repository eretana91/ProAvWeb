using DAL.DO.Objects;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace DAL.Repository
{
    public class RepositoryCustomerCustomerDemo : Repository<data.CustomerCustomerDemo>, IRepositoryCustomerCustomerDemo
    {
        public RepositoryCustomerCustomerDemo(NDbContext _dbContext) : base(_dbContext)
        {

        }

        public async Task<IEnumerable<CustomerCustomerDemo>> GetAllAsync()
        {
            return await _db.CustomerCustomerDemo.Include(n => n.Customer).Include(n=> n.CustomerType).ToListAsync();
        }

        public async Task<CustomerCustomerDemo> GetOneByIdAsync(string CustemerID, string CustomerTyperId)
        {
            return await _db.CustomerCustomerDemo.Include(n => n.Customer).Include(n => n.CustomerType).SingleOrDefaultAsync(n => n.CustomerId == CustemerID && n.CustomerTypeId == CustomerTyperId);
        }
        private NDbContext _db
        {
            get
            {
                return dbContext as NDbContext;
            }
        }
    }
}
