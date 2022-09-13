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
    public class EditModel : PageModel
    {
        private readonly IRepositorioImpresora repositorioImpresora;

        public Impresora Impresora { get; set; }

        public EditModel()
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
            if(!ModelState.IsValid){
                return Page();
            }
            if(Impresora.Id>0)
            {
                Impresora = repositorioImpresora.UpdateImpresora(Impresora);
            }
            else{
                repositorioImpresora.AddImpresora(Impresora);
            }
            return Page();

        }
    }
}
