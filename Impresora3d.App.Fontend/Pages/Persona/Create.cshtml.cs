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
    public class EditModelCO : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        [BindProperty]
        public Persona Persona { get; set; }

        public EditModelCO()
        {
            this.repositorioPersona = new RepositorioPersona(new Impresora3d.App.Persistencia.AppContext()); 
        }

        
        public IActionResult OnPost()
        {
            Console.WriteLine(Persona.Id);
            if(!ModelState.IsValid){
                return Page();
            }
            else{
                repositorioPersona.AddPersona(Persona);
                Console.WriteLine("Persona Creada");
            }
            return Page();

        }
    }
}
