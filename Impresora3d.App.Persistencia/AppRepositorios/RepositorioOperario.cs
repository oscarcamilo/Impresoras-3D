using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{

    public class RepositorioOperario :IRepositorioOperario
    {
        private readonly AppContext _appContext;

        public RepositorioOperario(AppContext appContext)
        {
            _appContext = appContext;
        }

         public Operario AddOperario(Operario operario)
        {
            var OperarioAdicionado = _appContext.Operarios.Add(operario);
            _appContext.SaveChanges();
            return OperarioAdicionado.Entity;

        }

        public void DeleteOperario(int idOperario)
        {
            var operarioEncontrado = _appContext.Operarios.FirstOrDefault(p => p.Id == idOperario);
            if (operarioEncontrado == null)
                return;
            _appContext.Operarios.Remove(operarioEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Operario> GetAllOperario()
        {
            return GetAllOperario_();
        }
        public IEnumerable<Operario> GetAllOperario_()
        {
            return _appContext.Operarios;
        }
         public Operario GetOperario(int idOperario)
        {
            return _appContext.Operarios.FirstOrDefault(p => p.Id == idOperario);
        }
       
         public Operario UpdateOperario(Operario operario)
        {
            var OperarioEncontrado = _appContext.Operarios.FirstOrDefault(p => p.Id == operario.Id);
            if (OperarioEncontrado != null)
            {
                OperarioEncontrado.Direccion = operario.Direccion;
                OperarioEncontrado.NivelEstudio = operario.NivelEstudio;
                                 
                _appContext.SaveChanges();


            }
            return OperarioEncontrado;
        }
        
    }
}