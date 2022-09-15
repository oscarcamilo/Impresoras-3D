using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresora3d.App.Persistencia.AppRepositorios;
using Impresora3d.App.Dominio;

namespace Impresora3d.App.Fontend.Pages
{
    public class ListModel2 : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        public IEnumerable<Persona> personas { get; set; }
        public string Discriminator { get; set; }
        

        public ListModel2()
        {
            this.repositorioPersona = new RepositorioPersona(new Impresora3d.App.Persistencia.AppContext()); 
        }
        
        public void OnGet()
        {
            personas=repositorioPersona.GetAllPersona();
            Discriminator=DataColumn;
        }
    }
}
