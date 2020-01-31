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
        [Display(Name = "Desde cuando congrega")]
        public string Cuando_Congrega { get; set; }
        [Display(Name = "1 Visita Iglesia")]
        public bool VisitaPrimera { get; set; }
        [Display(Name = "¿Acepto a Jesús?")]
        public bool Acepto_Jesus { get; set; }
        [Display(Name = "Año de salvación")]
        public int? Anio { get; set; }
        [Display(Name = "¿Es bautizado?")]
        public bool Bautizado { get; set; }
        [Display(Name = "Lugar de bautismo")]
        public string LugarBautismo { get; set; }
        [Display(Name = "Fecha bautismo")]
        public DateTime? FechaBautismo { get; set; }
        [Display(Name = "Razones estadía Mic")]
        public string Razones_Mic { get; set; }
        [Display(Name = "¿Desea consejería?")]
        public bool RecibirConsejeria { get; set; }
    }
}