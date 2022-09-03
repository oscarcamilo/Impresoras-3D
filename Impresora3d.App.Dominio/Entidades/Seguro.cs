using System;

namespace Impresora3d.App.Dominio
{
    public class Seguro{

        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }

    }
}