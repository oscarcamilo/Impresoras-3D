using System;
using Impresora3d.App.Dominio;
using Impresora3d.App.Persistencia.AppRepositorios;
using System.Collections.Generic;

namespace Impresora3d.App.Consola
{
    class Program
    {
         private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            AddPersona();


        }
        private static void AddPersona()
        {
            var persona = new Persona
            {
                Nombre = "Rodolfo",
                Apellidos = "Francis",
                NumeroTelefono = "31111645",
                FechaNacimiento = new DateTime(1990, 04, 12),
                Correo = "Rodolfitogmail.com"
            };
            _repoPersona.AddPersona(persona);

        }
    }
}
