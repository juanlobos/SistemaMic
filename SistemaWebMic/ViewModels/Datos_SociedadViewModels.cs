using System.ComponentModel.DataAnnotations;

namespace SistemaWebMic.ViewModels
{
    public class Datos_SociedadViewModels
    {
        [Display(Name = "Nivel Educación")]
        public string NivelEducacion { get; set; }
        [Display(Name = "Profesión")]
        public string Profesion { get; set; }
        [Display(Name = "Lugar de trabajo")]
        public string LugarTrabajo { get; set; }
    }
}