using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{

    public class RepositorioJefeOperaciones :IRepositorioJefeOperaciones
    {
        private readonly AppContext _appContext;

        public RepositorioJefeOperaciones(AppContext appContext)
        {
            _appContext = appContext;
        }

         public JefeOperaciones AddJefeOperaciones(JefeOperaciones jefeoperaciones)
        {
            var JefeOperacionesAdicionado = _appContext.Jefes.Add(jefeoperaciones);
            _appContext.SaveChanges();
            return JefeOperacionesAdicionado.Entity;

        }

        public void DeleteJefeOperaciones(int idJefeOperaciones)
        {
            var jefeoperacionesEncontrado = _appContext.Jefes.FirstOrDefault(p => p.Id == idJefeOperaciones);
            if (jefeoperacionesEncontrado == null)
                return;
            _appContext.Jefes.Remove(jefeoperacionesEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<JefeOperaciones> GetAllJefeOperaciones()
        {
            return GetAllJefeOperaciones_();
        }
        public IEnumerable<JefeOperaciones> GetAllJefeOperaciones_()
        {
            return _appContext.Jefes;
        }
         public JefeOperaciones GetJefeOperaciones(int idJefeOperaciones)
        {
            return _appContext.Jefes.FirstOrDefault(p => p.Id == idJefeOperaciones);
        }
       
         public JefeOperaciones UpdateJefeOperaciones(JefeOperaciones jefeoperaciones)
        {
            var JefeOperacionesEncontrado = _appContext.Jefes.FirstOrDefault(p => p.Id == jefeoperaciones.Id);
            if (JefeOperacionesEncontrado != null)
            {
                JefeOperacionesEncontrado.Id = jefeoperaciones.Id;
                                 
                _appContext.SaveChanges();


            }
            return JefeOperacionesEncontrado;
        }
        
    }
}