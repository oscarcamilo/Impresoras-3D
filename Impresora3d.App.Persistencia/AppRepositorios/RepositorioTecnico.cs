using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{

    public class RepositorioTecnico :IRepositorioTecnico
    {
        private readonly AppContext _appContext;

        public RepositorioTecnico(AppContext appContext)
        {
            _appContext = appContext;
        }

         public Tecnico AddTecnico(Tecnico tecnico)
        {
            var tecnicoAdicionado = _appContext.Tecnicos.Add(tecnico);
            _appContext.SaveChanges();
            return tecnicoAdicionado.Entity;

        }

        public void DeleteTecnico(int idTecnico)
        {
            var tecnicoEncontrado = _appContext.Tecnicos.FirstOrDefault(p => p.Id == idTecnico);
            if (tecnicoEncontrado == null)
                return;
            _appContext.Tecnicos.Remove(tecnicoEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Tecnico> GetAllTecnico()
        {
            return GetAllTecnico_();
        }
        public IEnumerable<Tecnico> GetAllTecnico_()
        {
            return _appContext.Tecnicos;
        }
         public Tecnico GetTecnico(int idTecnico)
        {
            return _appContext.Tecnicos.FirstOrDefault(p => p.Id == idTecnico);
        }
       
         public Tecnico UpdateTecnico(Tecnico tecnico)
        {
            var TecnicoEncontrado = _appContext.Tecnicos.FirstOrDefault(p => p.Id == tecnico.Id);
            if (TecnicoEncontrado != null)
            {
                TecnicoEncontrado.Id = tecnico.Id;
                TecnicoEncontrado.Direccion = tecnico.Direccion;
                TecnicoEncontrado.NivelEstudio = tecnico.NivelEstudio;
                 
                _appContext.SaveChanges();


            }
            return TecnicoEncontrado;
        }
        
    }
}