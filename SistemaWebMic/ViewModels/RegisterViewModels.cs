using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMic.ViewModels
{
    public class RegisterViewModels
    {
        public int Id { get; set; }

        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Display(Name="Fecha Nacimiento")]
        public DateTime Fecha_Nacimiento { get; set; }
        [Required]
        public string Nacionalidad { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        public string TCelular { get; set; }
        public string TCasa { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Estado_Civil { get; set; }
        public string Nombre_Pareja { get; set; }
        public bool? Hijos { get; set; }
        public int? Cantidad_Hijos { get; set; }
    }
}