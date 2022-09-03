using System;
using System.Collections.Generic;



namespace Impresora3d.App.Dominio
{
    public class Impresora{

        
        public int PlacaInventario { get; set; }
        public string Tipo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string PaisDeOrigen { get; set; }
        public string VolumenImpresion { get; set; }
        public string Software { get; set; }
        public string VelocidadImpresion { get; set; }

    }
}