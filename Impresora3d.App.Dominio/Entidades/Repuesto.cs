using System;

namespace Impresora3d.App.Dominio
{
    public class Repuesto{

        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaCompra { get; set; }
        public int ValorCompra { get; set; }

    }
}