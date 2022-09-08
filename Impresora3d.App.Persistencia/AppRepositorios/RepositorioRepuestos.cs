using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{

    public class RepositorioRepuestos :IRepositorioRepuestos
    {
        private readonly AppContext _appContext;

        public RepositorioRepuestos(AppContext appContext)
        {
            _appContext = appContext;
        }

         public Repuesto AddRepuesto(Repuesto repuesto)
        {
            var RepuestoAdicionado = _appContext.Repuestos.Add(repuesto);
            _appContext.SaveChanges();
            return RepuestoAdicionado.Entity;

        }

        public void DeleteRepuesto(int idRepuesto)
        {
            var repuestoEncontrado = _appContext.Repuestos.FirstOrDefault(p => p.Id == idRepuesto);
            if (repuestoEncontrado == null)
                return;
            _appContext.Repuestos.Remove(repuestoEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Repuesto> GetAllRepuesto()
        {
            return GetAllRepuesto_();
        }
        public IEnumerable<Repuesto> GetAllRepuesto_()
        {
            return _appContext.Repuestos;
        }
         public Repuesto GetRepuesto(int idRepuesto)
        {
            return _appContext.Repuestos.FirstOrDefault(p => p.Id == idRepuesto);
        }
       
         public Repuesto UpdateRepuesto(Repuesto repuesto)
        {
            var RepuestoEncontrado = _appContext.Repuestos.FirstOrDefault(p => p.Id == repuesto.Id);
            if (RepuestoEncontrado != null)
            {
                RepuestoEncontrado.Id = repuesto.Id;
                                 
                _appContext.SaveChanges();


            }
            return RepuestoEncontrado;
        }
        
    }
}