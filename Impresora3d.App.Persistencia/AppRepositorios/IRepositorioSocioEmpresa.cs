using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSocioEmpresa
    {
        IEnumerable<SocioEmpresa> GetAllSocioEmpresa();
        SocioEmpresa AddSocioEmpresa(SocioEmpresa socioempresa);
        SocioEmpresa UpdateSocioEmpresa(SocioEmpresa socioempresa);
        void DeleteSocioEmpresa(int idSocioEmpresa);    
        SocioEmpresa GetSocioEmpresa(int idSocioEmpresa); 
    }
}