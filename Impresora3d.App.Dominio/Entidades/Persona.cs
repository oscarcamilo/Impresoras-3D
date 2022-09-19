using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Impresora3d.App.Dominio
{
    public class Persona{
        public int Id { get; set;}
       // [Required, Range(1,100000000000)]
        public int Identificacion { get; set;}
        //[Required, StringLength(50)]
        public string Nombre { get; set;}
        //[Required, StringLength(50)]
        public string Apellidos { get; set;}
        //[Required, StringLength(50)]
        public string NumeroTelefono { get; set;}
        public DateTime FechaNacimiento { get; set;}
        //[Required, StringLength(50)]
        public string Correo { get; set;}
        //[Required, StringLength(50)]
        public string Direccion {get;set;}
        //[Required, StringLength(50)]
        public string NivelEstudio {get;set;}

    }
}