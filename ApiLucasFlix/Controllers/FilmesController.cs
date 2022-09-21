using ApiLucasFlix.Data;
using ApiLucasFlix.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApiLucasFlix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : Controller
    {
        private FilmeContext _context;

        public FilmesController(FilmeContext context)
        {
            this._context = context;
        }
            
        [HttpPost]
        public IActionResult AddFilme([FromBody] Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { Id = filme.Id},filme);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _context.Filmes.FirstOrDefault(filme => filme.Id.Equals(id));

            if (result == null)
                return NotFound();

            return Ok(result);
        }


        [HttpGet]
        public IActionResult GetAllFilmes(int id)
        {
            return Ok(_context.Filmes);
        }

    }
}
