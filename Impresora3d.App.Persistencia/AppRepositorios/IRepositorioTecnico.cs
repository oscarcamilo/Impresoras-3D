using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTecnico
    {
        IEnumerable<Tecnico> GetAllTecnico();
        Tecnico AddTecnico(Tecnico tecnico);
        Tecnico UpdateTecnico(Tecnico tecnico);
        void DeleteTecnico(int idTecnico);    
        Tecnico GetTecnico(int idTecnico); 
    }
}