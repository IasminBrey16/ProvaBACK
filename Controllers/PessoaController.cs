using System.Linq;
using ProvaBACK.Data;
using ProvaBACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProvaBACK.Controllers
{
    [ApiController]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly DataContext _context;
        public PessoaController(DataContext context)
        {
            _context = context;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody] Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            return Created("", pessoa);
        }

        [Route("list")]
        [HttpGet]
        public IActionResult List() => Ok(_context.Pessoas.ToList());
    }
}