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
    public class RepositoryLibros : Repository<data.Libros>, IRepositoryLibros
    {
        public RepositoryLibros(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Libros>> GetAllAsync()
        {
            //return null;
            return await _db.Libros.Include(n => n.Autor).ToListAsync();
        }

        public async Task<Libros> GetOneByIdAsync(string id)
        {
            return await _db.Libros.Include(n => n.Autor).SingleOrDefaultAsync(n => n.Id == id);
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
