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
        public int IdEspiritual { get; set; }
        [Display(Name = "¿Cuando llego?")]
        public string Llegada_Iglesia { get; set; }
        [Display(Name = "Quien lo invitó")]
        public string Invitacion_Iglesia { get; set; }
        [Display(Name = "Desde cuando congrega")]
        public string Cuando_Congrega { get; set; }
        public bool VisitaPrimera { get; set; }
        public bool Acepto_Jesus { get; set; }
        public int? Anio { get; set; }
        public bool Bautizado { get; set; }
        public string LugarBautismo { get; set; }
        public DateTime? FechaBautismo { get; set; }
        public string Razones_Mic { get; set; }
        public bool RecibirConsejeria { get; set; }
        public int PersonaId { get; set; }
    }
}