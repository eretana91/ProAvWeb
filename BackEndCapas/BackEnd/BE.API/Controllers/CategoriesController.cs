﻿using BE.DAL.DO.Objetos;
using BE.DAL.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BE.API.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly NDbContext _context;

        public CategoriesController(NDbContext context)
        {
            _context = context;
        }
        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> GetCategories()
        {
            return null;
            //return new BE.BS.Categories(_context).GetAll();
        }
    }
}
