using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);    
        Persona GetPersona(int idPersona);  
    }
}