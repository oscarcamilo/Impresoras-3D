using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Impresora3d.App.Persistencia.AppRepositorios
{

    public class RepositorioImpresora :IRepositorioImpresora
    {
        private readonly AppContext _appContext;

        public RepositorioImpresora(AppContext appContext)
        {
            _appContext = appContext;
        }

         public Impresora AddImpresora(Impresora impresora)
        {
            var impresoraAdicionado = _appContext.Impresoras.Add(impresora);
            _appContext.SaveChanges();
            return impresoraAdicionado.Entity;

        }

        public void DeleteImpresora(int idImpresora)
        {
            var impresoraEncontrado = _appContext.Impresoras.FirstOrDefault(p => p.Id == idImpresora);
            if (impresoraEncontrado == null)
                return;
            _appContext.Impresoras.Remove(impresoraEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Impresora> GetAllImpresoras()
        {
            return GetAllImpresoras_();
        }
        public IEnumerable<Impresora> GetAllImpresoras_()
        {
            return _appContext.Impresoras;
        }
         public Impresora GetImpresora(int idImpresora)
        {
            return _appContext.Impresoras.FirstOrDefault(p => p.Id == idImpresora);
        }
       
         public Impresora UpdateImpresora(Impresora impresora)
        {
            var impresoraEncontrado = _appContext.Impresoras.FirstOrDefault(p => p.Id == impresora.Id);
            if (impresoraEncontrado != null)
            {
                impresoraEncontrado.PlacaInventario = impresora.PlacaInventario;
                impresoraEncontrado.Tipo = impresora.Tipo;
                impresoraEncontrado.Marca = impresora.Marca;
                impresoraEncontrado.Modelo = impresora.Modelo;
                impresoraEncontrado.PaisDeOrigen = impresora.PaisDeOrigen;
                impresoraEncontrado.VolumenImpresion = impresora.VolumenImpresion;
                impresoraEncontrado.Software = impresora.Software;
                impresoraEncontrado.VelocidadImpresion = impresora.VelocidadImpresion;
                
                _appContext.SaveChanges();


            }
            return impresoraEncontrado;
        }
        
    }
}