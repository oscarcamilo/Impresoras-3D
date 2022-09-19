using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Impresora3d.App.Dominio
{
    public class Impresora{

        public int Id { get; set; }
        [Required, Range(1,100000000)]
        public int PlacaInventario { get; set; }
        [Required, StringLength(50)]
        public string Tipo { get; set; }
        [Required, StringLength(50)]
        public string Marca { get; set; }
        [Required, StringLength(50)]
        public string Modelo { get; set; }
        [Required, StringLength(50)]
        public string PaisDeOrigen { get; set; }
        [Required, StringLength(50)]
        public string VolumenImpresion { get; set; }
        [Required, StringLength(50)]
        public string Software { get; set; }
        [Required, StringLength(50)]
        public string VelocidadImpresion { get; set; }

    }
}