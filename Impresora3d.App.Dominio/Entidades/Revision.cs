using System;

namespace Impresora3d.App.Dominio
{
    public class Revision{

        public int Id { get; set; }
        public string Tipo { get; set; }
        public int ValorRevision { get; set; }
        public DateTime FechaHoraRevision { get; set; }

    }
}