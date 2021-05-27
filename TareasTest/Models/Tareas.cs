using System;
using System.ComponentModel.DataAnnotations;

namespace TareasTest.Models
{
    public class Tareas
    {
       
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage = "El Titulo es requerido")]
        [StringLength(50, ErrorMessage = "Contraseña requiere mas de 5 caracteres.", MinimumLength = 5)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La descripcion es requerido")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Encargado es requerido")]
        public string Encargado { get; set; }

    }
}
