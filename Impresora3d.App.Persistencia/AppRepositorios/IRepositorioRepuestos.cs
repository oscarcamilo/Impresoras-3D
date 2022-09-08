using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRepuestos
    {
        IEnumerable<Repuesto> GetAllRepuesto();
        Repuesto AddRepuesto(Repuesto repuesto);
        Repuesto UpdateRepuesto(Repuesto repuesto);
        void DeleteRepuesto(int idRepuesto);    
        Repuesto GetRepuesto(int idRepuesto); 
    }
}