using System;
namespace SistemaWebMic.Models.Entidades
{
    public class Datos_Espirituales
    {
        public int Id { get; set; }
        public string Llegada_Iglesia { get; set; }
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
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}