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
    public class ListModel : PageModel
    {
        private readonly IRepositorioImpresora repositorioImpresora;
        public IEnumerable<Impresora> impresoras { get; set; }
        [BindProperty]
        public Impresora Impresora { get; set; }


        public ListModel()
        {
            this.repositorioImpresora = new RepositorioImpresora(new Impresora3d.App.Persistencia.AppContext()); 
        }

        public void OnGet()
        {
            impresoras=repositorioImpresora.GetAllImpresoras();
            
        }
        public IActionResult OnPost(int? impresoraId)
        {
            Console.WriteLine(impresoraId.Value);
            if(!ModelState.IsValid){
                return Page();
            }
            if(impresoraId.Value>=0)
            {
                repositorioImpresora.DeleteImpresora(impresoraId.Value);
            }
            
            return Page();

        }
        
       
    }
}
