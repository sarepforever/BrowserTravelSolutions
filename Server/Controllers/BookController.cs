using BrowserTravel.Shared.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        //private readonly obj database context;

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="context">Database Context</param>
        public BookController(AplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Santiago Perea 2022-Mar-03
        /// Method to load description of a book
        /// </summary>       
        /// <returns> book list</returns>
        // GET: api/<LibrosController>
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<ICollection<GETBookDTO>>> Get()
        {
            var result = await (from s in _context.Libros
                                select new GETBookDTO
                                {
                                    id = s.id,
                                    titulo = s.titulo,
                                    paginas = s.numPaginas,
                                    nombreEditorial = s.Editorial.nombre,
                                    urlImagen = s.urlImagen,
                                    _autores = (from a in s._Autor_Has_Libros
                                                select $"{a.Autor.nombre} {a.Autor.apellidos}"
                                               ).ToList(),
                                }).ToListAsync();
            return result;
        }

        /// <summary>
        /// Santiago Perea 2022-Mar-03
        /// Method to load description of a book
        /// </summary>       
        /// <param name="id"></param>         
        /// <returns> details of a book</returns>
        // GET api/<LibrosController>/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<GETBookIdDTO>> Get(int id)
        {
            var result = await (from s in _context.Libros
                                where s.id == id
                                select new GETBookIdDTO
                                {
                                    titulo = s.titulo,
                                    paginas = s.numPaginas,
                                    nombreEditorial = s.Editorial.nombre,
                                    sedeEditorial = s.Editorial.sede,
                                    sinopsis = s.sinopsis,
                                    urlImagen = s.urlImagen,
                                    _autores = (from a in s._Autor_Has_Libros
                                                select $"{a.Autor.nombre} {a.Autor.apellidos}"
                                              ).ToList(),
                                }).FirstOrDefaultAsync();
            if (result == null)
            {
                return NotFound("Resource not found");
            }

            return result;
        }
    }
}
