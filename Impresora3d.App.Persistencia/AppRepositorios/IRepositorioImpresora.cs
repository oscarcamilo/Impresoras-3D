using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;
using System.Collections;

namespace Impresora3d.App.Persistencia.AppRepositorios
{
    public interface IRepositorioImpresora
    {
        IEnumerable<Impresora> GetAllImpresoras();
        Impresora AddImpresora(Impresora impresora);
        Impresora UpdateImpresora(Impresora impresora);
        void DeleteImpresora(int idImpresora);    
        Impresora GetImpresora(int idImpresora);
    }
}