using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMic.ViewModels
{
    public class Datos_EspiritualesViewModels
    {
        public int Id { get; set; }
        [Display(Name = "¿Cuando llego?")]
        public string Llegada_Iglesia { get; set; }
        [Display(Name = "¿Quien lo invitó?")]
        public string Invitacion_Iglesia { get; set; }
        public string Cuando_Congrega { get; set; }
        public bool VisitaPrimera { get; set; }
        public bool Acepto_Jesus { get; set; }
        public int? Anio { get; set; }
        public bool Bautizado { get; set; }
        public string LugarBautismo { get; set; }
        public DateTime? FechaBautismo { get; set; }
        public string Razones_Mic { get; set; }
        public bool RecibirConsejeria { get; set; }
    }
}