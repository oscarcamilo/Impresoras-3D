using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{

    public class RepositorioAuxiliar :IRepositorioAuxiliar
    {
        private readonly AppContext _appContext;

        public RepositorioAuxiliar(AppContext appContext)
        {
            _appContext = appContext;
        }

         public Auxiliar AddAuxiliar(Auxiliar auxiliar)
        {
            var auxiliarAdicionado = _appContext.Auxiliares.Add(auxiliar);
            _appContext.SaveChanges();
            return auxiliarAdicionado.Entity;

        }

        public void DeleteAuxiliar(int idAuxiliar)
        {
            var auxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(p => p.Id == idAuxiliar);
            if (auxiliarEncontrado == null)
                return;
            _appContext.Auxiliares.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Auxiliar> GetAllAuxiliar()
        {
            return GetAllAuxiliar_();
        }
        public IEnumerable<Auxiliar> GetAllAuxiliar_()
        {
            return _appContext.Auxiliares;
        }
         public Auxiliar GetAuxiliar(int idAuxiliar)
        {
            return _appContext.Auxiliares.FirstOrDefault(p => p.Id == idAuxiliar);
        }
       
         public Auxiliar UpdateAuxiliar(Auxiliar auxiliar)
        {
            var AuxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(p => p.Id == auxiliar.Id);
            if (AuxiliarEncontrado != null)
            {
                AuxiliarEncontrado.Direccion = auxiliar.Direccion;
                AuxiliarEncontrado.NivelEstudio = auxiliar.NivelEstudio;
                 
                _appContext.SaveChanges();


            }
            return AuxiliarEncontrado;
        }
        
    }
}