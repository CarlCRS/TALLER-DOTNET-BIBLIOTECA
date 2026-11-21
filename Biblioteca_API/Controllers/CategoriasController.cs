using Biblioteca_API.Models;
using Microsoft.AspNetCore.Mvc;


namespace Biblioteca_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private static List<Categoria> categorias = new List<Categoria>
        {
            new Categoria { Id = 1, Nombre = "Ficción" },
            new Categoria { Id = 2, Nombre = "No Ficción" }
        };

        // GET: api/categorias
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(categorias);
        }
    }
}