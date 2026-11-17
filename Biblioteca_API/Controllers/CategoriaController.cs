using Biblioteca_API.Models;
using Microsoft.AspNetCore.Mvc;


namespace TaskFlowApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoriaController : ControllerBase
    {
        private static List<Categoria> categorias = new List<Categoria>
        {
            new Categoria { Id = 1, Nombre = "Ficción" },
            new Categoria { Id = 2, Nombre = "No Ficción" }
        };

        // GET: api/<ValuesController>
        // http://localhost:5252/api/categoria
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(categorias);
        }
    }
}
