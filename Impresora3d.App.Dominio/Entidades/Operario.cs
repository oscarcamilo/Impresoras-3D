using System;

namespace Impresora3d.App.Domnio
{
    public class Operario: Persona{

        public string Direccion { get; set; }
        public string NivelEstudio { get; private set; } 
        public List<Impresora> ImpresoraACargo { get; set; }

        //Pendiente ImpresoraACargo
        
    }
}