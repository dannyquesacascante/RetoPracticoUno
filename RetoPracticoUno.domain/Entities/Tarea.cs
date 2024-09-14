﻿namespace RetoPracticoUno.domain.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public bool Completada { get; set; }


        public Tarea(string titulo, string descripcion, int id)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Completada = false;
            Id = id;
        }

        public void MarcarComoCompletada()
        {
            Completada = true;
        }

    }

}
