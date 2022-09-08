using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Persistencia.AppRepositorios
{
    public interface IRepositorioJefeOperaciones
    {
        IEnumerable<JefeOperaciones> GetAllJefeOperaciones();
        JefeOperaciones AddJefeOperaciones(JefeOperaciones jefeoperaciones);
        JefeOperaciones UpdateJefeOperaciones(JefeOperaciones jefeoperaciones);
        void DeleteJefeOperaciones(int idJefeOperaciones);    
        JefeOperaciones GetJefeOperaciones(int idJefeOperaciones);
    }
}