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
            _context.Tarea.Add(tarea);
            _context.SaveChanges();
        }

        public IEnumerable<Tarea> ObtenerTodas()
        {
            return _context.Tarea.ToList();
        }

        public Tarea ObtenerPorId(int id)
        {
           var t = _context.Tarea.Find(id);
            Console.WriteLine(t.Titulo);

            return t;
        }

        public void Actualizar(Tarea tarea)
        {
            _context.Tarea.Update(tarea);
      _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var t = new Tarea (id);
            _context.Tarea.Attach(t);
            _context.Tarea.Remove(t);
            _context.SaveChanges();
        }
    }
}
