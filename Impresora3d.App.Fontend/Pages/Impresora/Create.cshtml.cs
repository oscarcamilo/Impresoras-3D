using System.ComponentModel;
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
    public class EditModelCI : PageModel
    {
        private readonly IRepositorioImpresora repositorioImpresora;
        [BindProperty]
        public Impresora Impresora { get; set; }

        public EditModelCI()
        {
            this.repositorioImpresora = new RepositorioImpresora(new Impresora3d.App.Persistencia.AppContext()); 
        }

        
        public IActionResult OnPost()
        {
            Console.WriteLine(Impresora.Id);
            if(!ModelState.IsValid){
                return Page();
            }
            else{
                repositorioImpresora.AddImpresora(Impresora);
                Console.WriteLine("Impresora Creada");
            }
            return Page();

        }
    }
}
