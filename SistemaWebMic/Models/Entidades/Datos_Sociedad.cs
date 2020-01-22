namespace SistemaWebMic.Models.Entidades
{
    public class Datos_Sociedad
    {
        public int Id { get; set; }
        public string NivelEducacion { get; set; }
        public string Profesion { get; set; }
        public string LugarTrabajo { get; set; }
        public int PersonaId{ get; set; }

        public Persona Persona { get; set; }
    }
}