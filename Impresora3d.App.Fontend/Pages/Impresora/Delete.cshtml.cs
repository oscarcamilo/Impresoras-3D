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
    public class DeleteIModel : PageModel
    {
        private readonly IRepositorioImpresora repositorioImpresora;
        [BindProperty]
        public Impresora Impresora { get; set; }

        public DeleteIModel()
        {
            this.repositorioImpresora = new RepositorioImpresora(new Impresora3d.App.Persistencia.AppContext()); 
        }

        public IActionResult OnGet(int? impresoraId)
        {
            if(impresoraId.HasValue)
            {
                Impresora = repositorioImpresora.GetImpresora(impresoraId.Value);
            }
            else{
                Impresora = new Impresora();
            }
            if(Impresora == null){
                return RedirectToPage("./NotFound");
            }
            else
               return Page();

        }

        public IActionResult OnPost()
        {
            Console.WriteLine(Impresora.Id);
            if(!ModelState.IsValid){
                return Page();
            }
            if(Impresora.Id>=0)
            {
                Console.WriteLine(Impresora.Id);
                repositorioImpresora.DeleteImpresora(Impresora.Id);
                return RedirectToPage("./List");
            }
            
            return Page();

        }
    }
}
