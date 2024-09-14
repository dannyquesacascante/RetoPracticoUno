namespace RetoPracticoUno.domain.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public enum Estado { Completo, NoCompleto }

    }

}
