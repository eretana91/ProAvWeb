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
    public class ProdutcsController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public ProdutcsController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/Libros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Libros>>> GetLibros()
        {
            var res = await new BE.Libros(_context).GetAllAsync();
            List<models.Libros> mapaAux = _mapper.Map<IEnumerable<data.Libros>, IEnumerable<models.Libros>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Libros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Libros>> GetLibros(string id)
        {
            var Libros = await new BE.Libros(_context).GetOneByIdAsync(id);

            if (Libros == null)
            {
                return NotFound();
            }
            models.Libros mapaAux = _mapper.Map<data.Libros, models.Libros>(Libros);
            return mapaAux;
        }

        // PUT: api/Libros/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibros(string id, models.Libros Libros)
        {
            if (id != Libros.Id)
            {
                return BadRequest();
            }

            try
            {
                data.Libros mapaAux = _mapper.Map<models.Libros, data.Libros>(Libros);
                new BE.Libros(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!LibrosExists(id))
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

        // POST: api/Libros
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Libros>> PostLibros(models.Libros Libros)
        {
            try
            {
                data.Libros mapaAux = _mapper.Map<models.Libros, data.Libros>(Libros);
                new BE.Libros(_context).Insert(mapaAux);
            }
            catch (Exception ee)
            {

                BadRequest();
            }

            return CreatedAtAction("GetLibros", new { id = Libros.Id }, Libros);
        }

        // DELETE: api/Libros/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Libros>> DeleteLibros(string id)
        {
            var Libros = await new BE.Libros(_context).GetOneByIdAsync(id);
            if (Libros == null)
            {
                return NotFound();
            }
            try
            {
                new BE.Libros(_context).Delete(Libros);
            }
            catch (Exception)
            {

                BadRequest();
            }

            models.Libros mapaAux = _mapper.Map<data.Libros, models.Libros>(Libros);

            return mapaAux;
        }

        private bool LibrosExists(string id)
        {
            return (new BE.Libros(_context).GetOneById(id) != null);
        }
    }
}
