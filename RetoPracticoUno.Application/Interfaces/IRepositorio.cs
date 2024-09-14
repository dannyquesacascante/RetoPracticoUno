using RetoPracticoUno.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoPracticoUno.Application.Interface
{
    public interface IRepositorio
    {

        void Crear(Tarea tarea);
        IEnumerable<Tarea> ObtenerTodas();
        Tarea ObtenerPorId(int id);
        void Actualizar(Tarea tarea);
        void Eliminar(Tarea tarea);
    }
}
