using System;


namespace Impresora3d.App.Domnio
{
    public class Persona{

        public int Id { get; set;}
        public string Nombre { get; set;}
        public string Apellidos { get; set;}
        public string NumeroTelefono { get; set;}
        public DateTime FechaNacimiento { get; set;}
        public string Correo { get; set;}
    }
}