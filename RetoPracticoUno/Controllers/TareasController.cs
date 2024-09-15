using Microsoft.AspNetCore.Mvc;
using RetoPracticoUno.Application.Servicios;
using RetoPracticoUno.domain.Entities;
namespace RetoPracticoUno.Controllers
{
    public class TareasController : Controller
    {
        private readonly TareaServicio _tareaService;

        public TareasController(TareaServicio tareaService)
        {
            _tareaService = tareaService;
        }

        [HttpPost]
        [Route("CrearTarea")]
        public IActionResult CrearTarea([FromBody] TareaDto dto)
        {
            _tareaService.CrearTarea(dto.Titulo, dto.Descripcion,dto.Id);
            return Ok();
        }
    }
}
