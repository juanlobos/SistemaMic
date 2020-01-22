using System;
using System.Collections.Generic;

namespace SistemaWebMic.Models.Entidades
{
    public class Persona
    {
        private ICollection<Datos_Espirituales> enrollments;

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Nacionalidad { get; set; }
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
        public Datos_Espirituales Espiritual { get; set; }
        public Datos_Sociedad Sociedad{ get; set; }

    }
}