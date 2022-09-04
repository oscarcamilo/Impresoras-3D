using System;
using System.Collections.Generic;


namespace Impresora3d.App.Dominio
{
    public class Tecnico : Persona{

        public int Id { get; set; }
        public string Direccion {get;set;}
        public string NivelEstudio {get;set;}
        //public List<Impresora> ImpresoraACargo { get; set; }       
        
    }
}