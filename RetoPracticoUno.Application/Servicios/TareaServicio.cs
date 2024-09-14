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



    }
}
