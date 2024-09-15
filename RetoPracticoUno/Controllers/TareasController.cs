using Microsoft.AspNetCore.Http.HttpResults;
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
        [Route("creartarea")]
        public IActionResult CrearTarea([FromBody] TareaDto dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _tareaService.CrearTarea(dto.Titulo, dto.Descripcion,dto.Id);
            return Ok();
        }

        [HttpGet]
        [Route("obtener/{id:int}")]
        public IActionResult obtenertarea(int id)
        {
           var t= _tareaService.ObtenerTarea(id);
          return StatusCode(StatusCodes.Status200OK, new { response = t });

        }

        [HttpPut]
        [Route("actualizartarea")]
        public IActionResult actualizartarea([FromBody] TareaDto dto)
        {
       
          _tareaService.actualizarTarea(dto.Titulo, dto.Descripcion, dto.Id);
        return Ok();

        }

        [HttpPut]
        [Route("tareacompletada/{id:int}")]
        public IActionResult actualizartareaestado(int id)
        {

            _tareaService.tareaCompletada(id);
            return Ok();

        }

        [HttpGet]
        [Route("listado")]
        public IActionResult listado()
        {
            var listado = _tareaService.listadoTareas();
            return StatusCode(StatusCodes.Status200OK, new { response = listado });

        }



        [HttpDelete]
        [Route("eliminartarea/{id:int}")]
        public IActionResult eliminar(int id)
        {
           _tareaService.eliminarTarea(id);
            return Ok();

        }



    }
}
