using System;
using System.Collections.Generic;



namespace Impresora3d.App.Dominio
{
    public class Impresora{
       
        
        public int Id { get; set; }
        public int PlacaInventario { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string PaisDeOrigen { get; set; }
        public string VolumenImpresion { get; set; }
        public string Software { get; set; }
        public string VelocidadImpresion { get; set; }

    }
}