using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetoPracticoUno.Application.Interface;
using RetoPracticoUno.domain.Entities;

namespace RetoPracticoUno.Application.Servicios
{
    

    public class TareaServicio
    {


        private readonly IRepositorio _tareaRepository;

        public TareaServicio(IRepositorio tareaRepository)
        {
            _tareaRepository = tareaRepository;
        }

        public void CrearTarea(string titulo, string descripcion, int id)
        {
            var tarea = new Tarea(titulo, descripcion, id);
            _tareaRepository.Crear(tarea);
        }

        public Tarea ObtenerTarea( int id)
        {
            return _tareaRepository.ObtenerPorId(id);
        }

        public void actualizarTarea(string titulo, string descripcion, int id)
        {
            var tarea = new Tarea(titulo, descripcion, id);
            _tareaRepository.Actualizar(tarea);
        }

        public void tareaCompletada( int id)
        {
            var tarea = _tareaRepository.ObtenerPorId(id);
            tarea.MarcarComoCompletada();
            _tareaRepository.Actualizar(tarea);
        }

        public IEnumerable<Tarea> listadoTareas()
        {
            return _tareaRepository.ObtenerTodas();
        }

        public void eliminarTarea(int id)
        {
             _tareaRepository.Eliminar(id);
        }

    }
}
