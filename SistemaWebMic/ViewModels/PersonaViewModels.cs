using System;
using System.ComponentModel.DataAnnotations;
using SistemaWebMic.Models.Entidades;

namespace SistemaWebMic.ViewModels
{
    public class PersonaViewModels
    {
        public int Id { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Nacimiento { get; set; }
        [Required]
        public string Nacionalidad { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public string TCelular { get; set; }
        [Display(Name = "Teléfono casa")]
        [DataType(DataType.PhoneNumber)]
        public string TCasa { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Facebook { get; set; }
        [Display(Name = "Estado Civil")]
        public string Estado_Civil { get; set; }
        [Display(Name = "Nombre Pareja")]
        public string Nombre_Pareja { get; set; }
        [Display(Name = "Tiene Hijos")]
        public bool? Hijos { get; set; }
        [Display(Name = "Cantidad Hijos")]
        public int? Cantidad_Hijos { get; set; }
        public Datos_EspiritualesViewModels Espiritual { get; set; }
        public Datos_SociedadViewModels Sociedad { get; set; }
    }
}