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
    public class DeleteIIModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        [BindProperty]
        public Persona Persona { get; set; }

        public DeleteIIModel()
        {
            this.repositorioPersona = new RepositorioPersona(new Impresora3d.App.Persistencia.AppContext()); 
        }

        public IActionResult OnGet(int? personaId)
        {
            if(personaId.HasValue)
            {
                Persona = repositorioPersona.GetPersona(personaId.Value);
            }
            else{
                Persona = new Persona();
            }
            if(Persona == null){
                return RedirectToPage("./NotFound");
            }
            else
               return Page();

        }

        public IActionResult OnPost()
        {
            Console.WriteLine(Persona.Id);
            if(!ModelState.IsValid){
                return Page();
            }
            if(Persona.Id>=0)
            {
                Console.WriteLine(Persona.Id);
                repositorioPersona.DeletePersona(Persona.Id);
                return RedirectToPage("./List");
            }
            
            return Page();

        }
    }
}
