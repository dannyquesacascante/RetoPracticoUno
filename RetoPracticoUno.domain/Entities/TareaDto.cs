using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoPracticoUno.domain.Entities
{
    public class TareaDto
    {
        [Required(ErrorMessage = "El id es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID debe ser mayor que 0.")]

        public int Id { get; set; }


        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(50, ErrorMessage = "El título no puede exceder los 50 caracteres.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "La Descripcion  es obligatorio.")]
        [StringLength(50, ErrorMessage = "La Descripcion no puede exceder los 50 caracteres.")]
        public string? Descripcion { get; set; }
    }
}
