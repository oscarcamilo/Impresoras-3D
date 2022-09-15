using System;
using System.Collections.Generic;

namespace Impresora3d.App.Dominio
{
    public class Persona{
        public int Id { get; set;}
        public int Identificacion { get; set;}
        public string Nombre { get; set;}
        public string Apellidos { get; set;}
        public string NumeroTelefono { get; set;}
        public DateTime FechaNacimiento { get; set;}
        public string Correo { get; set;}
        public string Direccion {get;set;}
        public string NivelEstudio {get;set;}

    }
}