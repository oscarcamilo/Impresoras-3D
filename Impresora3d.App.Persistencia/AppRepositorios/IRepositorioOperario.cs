using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{
    public interface IRepositorioOperario
    {
        IEnumerable<Operario> GetAllOperario();
        Operario AddOperario(Operario operario);
        Operario UpdateOperario(Operario operario);
        void DeleteOperario(int idOperario);    
        Operario GetOperario(int idOperario);   
    }
}