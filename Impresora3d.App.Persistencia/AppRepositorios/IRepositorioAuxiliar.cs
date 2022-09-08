using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> GetAllAuxiliar();
        Auxiliar AddAuxiliar(Auxiliar auxiliar);
        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);
        void DeleteAuxiliar(int idAuxiliar);    
        Auxiliar GetAuxiliar(int idAuxiliar);
    }
}