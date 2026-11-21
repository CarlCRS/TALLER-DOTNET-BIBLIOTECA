using Biblioteca_API.Models;
using Microsoft.AspNetCore.Mvc;


namespace Biblioteca_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private static List<Libro> libros = new List<Libro>
        {
            new Libro { Id = 1, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", Disponible = true },
            new Libro { Id = 2, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", Disponible = false }
        };

        // GET: api/libros
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(libros);
        }

        // GET api/libros/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                return Ok(libro);
            }
            return NotFound();
        }

        // POST api/libros
        [HttpPost]
        public IActionResult Post([FromBody] Libro libro)
        {
            libro.Id = libros.Count > 0 ? libros.Max(l => l.Id) + 1 : 1;
            libros.Add(libro);
            return Created("", libro);
        }

        // PUT api/libros/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Libro value)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                libro.Titulo = value.Titulo;
                libro.Autor = value.Autor;
                libro.Disponible = value.Disponible;
                return Ok("Libro actualizado");
            }
            return NotFound();
        }

        // DELETE api/libros/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                libros.Remove(libro);
                return Ok("Libro eliminado");
            }
            return NotFound();
        }
    }
}