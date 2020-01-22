using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMic.ViewModels
{
    public class MiembrosViewModels
    {
        public int Id { get; set; }
        
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Nacimiento { get; set; }
        public string Nacionalidad { get; set; }
        [Display(Name = "Dirección Particular")]
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public string TCelular { get; set; }
        [Display(Name = "Teléfono Casa")]
        [DataType(DataType.PhoneNumber)]
        public string TCasa { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Estado Civil")]
        public string Estado_Civil { get; set; }
    }
}