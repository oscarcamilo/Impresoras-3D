using System;

namespace Impresora3d.App.Domnio
{
    public class Tecnico : Persona{

        public string Direccion {get;set;}
        public string NivelEstudio {get;set;}
        public List<Impresora> ImpresoraACargo { get; set; }
        //Pendiente ImpresorasACargo
        
    }
}