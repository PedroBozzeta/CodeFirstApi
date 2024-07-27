using Codefirst.DB;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private PruebaContext _context;

        public EmpleadoController(PruebaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Empleado> Get() => _context.Empleados.ToList();
    }
}
