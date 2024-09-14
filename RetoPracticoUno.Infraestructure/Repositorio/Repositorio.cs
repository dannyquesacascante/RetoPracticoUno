using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetoPracticoUno.Application.Interface;
using RetoPracticoUno.domain.Entities;
namespace RetoPracticoUno.Infraestructure.Repositorio
{
    public class Repositorio : IRepositorio
    {
        private readonly ApplicationDbContext _context;
        public Repositorio(ApplicationDbContext context)
        {
            _context = context;

        }

        public void Crear(Tarea tarea)
        {
            _context.Tareas.Add(tarea);
            _context.SaveChanges();
        }

        public IEnumerable<Tarea> ObtenerTodas()
        {
            return _context.Tareas.ToList();
        }

        public Tarea ObtenerPorId(int id)
        {
            return _context.Tareas.Find(id);
        }

        public void Actualizar(Tarea tarea)
        {
            _context.Tareas.Update(tarea);
            _context.SaveChanges();
        }

        public void Eliminar(Tarea tarea)
        {
            _context.Tareas.Remove(tarea);
            _context.SaveChanges();
        }
    }
}
