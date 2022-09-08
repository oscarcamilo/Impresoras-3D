using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{

    public class RepositorioPersona :IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

         public Persona AddPersona(Persona persona)
        {
            var PersonaAdicionado = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return PersonaAdicionado.Entity;

        }

        public void DeletePersona(int idPersona)
        {
            var personaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if (personaEncontrado == null)
                return;
            _appContext.Personas.Remove(personaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Persona> GetAllPersona()
        {
            return GetAllPersona_();
        }
        public IEnumerable<Persona> GetAllPersona_()
        {
            return _appContext.Personas;
        }
         public Persona GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }
       
         public Persona UpdatePersona(Persona persona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (PersonaEncontrado != null)
            {
                PersonaEncontrado.Id = persona.Id;
                PersonaEncontrado.Nombre = persona.Nombre;
                PersonaEncontrado.Apellidos = persona.Apellidos;
                PersonaEncontrado.NumeroTelefono = persona.NumeroTelefono;
                PersonaEncontrado.FechaNacimiento = persona.FechaNacimiento;
                PersonaEncontrado.Correo = persona.Correo;
                                 
                _appContext.SaveChanges();


            }
            return PersonaEncontrado;
        }
        
    }
}