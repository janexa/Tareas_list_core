using System;
using System.ComponentModel.DataAnnotations;
namespace TareasTest.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El Correo es requerido")]
        [EmailAddress]
        public string Correo { get; set; }

        //[Required]
        //[StringLength(8, ErrorMessage = "Contraseña requiere mas de 8 caracteres.")]
        //public string Contraseña { get; set; }

        [Required(ErrorMessage ="La contraseña es requerida")]
        [StringLength(50, ErrorMessage = "Contraseña requiere mas de 8 caracteres.", MinimumLength = 8)]
        public string Contraseña { get; set; }

    }
}
