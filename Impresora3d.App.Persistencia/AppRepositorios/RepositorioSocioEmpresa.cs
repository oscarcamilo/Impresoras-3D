using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{

    public class RepositorioSocioEmpresa :IRepositorioSocioEmpresa
    {
        private readonly AppContext _appContext;

        public RepositorioSocioEmpresa(AppContext appContext)
        {
            _appContext = appContext;
        }

         public SocioEmpresa AddSocioEmpresa(SocioEmpresa socioempresa)
        {
            var SocioEmpresaAdicionado = _appContext.Socios.Add(socioempresa);
            _appContext.SaveChanges();
            return SocioEmpresaAdicionado.Entity;

        }

        public void DeleteSocioEmpresa(int idSocioEmpresa)
        {
            var socioempresaEncontrado = _appContext.Socios.FirstOrDefault(p => p.Id == idSocioEmpresa);
            if (socioempresaEncontrado == null)
                return;
            _appContext.Socios.Remove(socioempresaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<SocioEmpresa> GetAllSocioEmpresa()
        {
            return GetAllSocioEmpresa_();
        }
        public IEnumerable<SocioEmpresa> GetAllSocioEmpresa_()
        {
            return _appContext.Socios;
        }
         public SocioEmpresa GetSocioEmpresa(int idSocioEmpresa)
        {
            return _appContext.Socios.FirstOrDefault(p => p.Id == idSocioEmpresa);
        }
       
         public SocioEmpresa UpdateSocioEmpresa(SocioEmpresa socioempresa)
        {
            var SocioEmpresaEncontrado = _appContext.Socios.FirstOrDefault(p => p.Id == socioempresa.Id);
            if (SocioEmpresaEncontrado != null)
            {
                SocioEmpresaEncontrado.Id = socioempresa.Id;
                                 
                _appContext.SaveChanges();


            }
            return SocioEmpresaEncontrado;
        }
        
    }
}