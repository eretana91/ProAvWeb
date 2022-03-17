using AutoMapper;
using DAL.DO.Objects;
using DAL.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
using models = API.DataModels;

namespace API.Controllers
{
 [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public CustomersController(NDbContext context)
        {
            _context = context;
        }
        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Customers>>> GetCategories()
        {
            //return null;
            //return new BE.BS.Customers(_context).GetAll().ToList();
            var res = new BE.Customers(_context).GetAll();
            List<models.Customers> mapaAux = _mapper.Map<IEnumerable<data.Customers>, IEnumerable<models.Customers>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Customers>> GetCategories(int id)
        {
            var customers = new BE.Customers(_context).GetOneById(id);

            if (customers == null)
            {
                return NotFound();
            }
            models.Customers mapaAux = _mapper.Map<data.Customers, models.Customers>(customers);
            return mapaAux;
        }
        // PUT: api/Customers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategories(string id, models.Customers categories)
        {
            if (id != categories.CustomerId)
            {
                return BadRequest();
            }

            try
            {
                data.Customers mapaAux = _mapper.Map<models.Customers, data.Customers>(categories);
                new BE.Customers(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!CategoriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Customers>> PostCategories(models.Customers categories)
        {
            try
            {
                data.Customers mapaAux = _mapper.Map<models.Customers, data.Customers>(categories);
                new BE.Customers(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            }            

            return CreatedAtAction("GetCategories", new { id = categories.CategoryId }, categories);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Customers>> DeleteCategories(int id)
        {
            var categories = new BE.Customers(_context).GetOneById(id);
            if (categories == null)
            {
                return NotFound();
            }
            try
            {
                new BE.Customers(_context).Delete(categories);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.Customers mapaAux = _mapper.Map<data.Customers, models.Customers>(categories);

            return mapaAux;
        }
        private bool Exists(string id)
        {
            return (new BE.Customers(_context).GetOneById(id) != null);
        }
    }
}
