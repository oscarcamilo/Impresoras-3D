using System;
using Impresora3d.App.Dominio;
using Impresora3d.App.Persistencia.AppRepositorios;
using System.Collections.Generic;

namespace Impresora3d.App.Consola
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioImpresora _repoImpresora = new RepositorioImpresora(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            //AddPersona();
            AddImpresora();
            ListarAllImpresoras();


        }
        private static void AddPersona()
        {
            var persona = new Persona{
                Nombre = "Rosa",
                Apellidos = "Garzon",
                NumeroTelefono = "31156986",
                FechaNacimiento = new DateTime(1997, 06, 15),
                Correo = "Rosagarz@gmail.com"
            };
            _repoPersona.AddPersona(persona);

        }
        private static void AddImpresora()
        {
            var impresora = new Impresora{
                PlacaInventario = 001,
                Tipo = "Polar",
                Marca = "Ceality",
                Modelo = "2015",
                PaisDeOrigen = "Estados Unidos",
                VolumenImpresion = "16X16",
                Software = "Marlin. Slicers",
                VelocidadImpresion = "≤180mm/s, Normally operation is 30-60mm/s"
            };
            _repoImpresora.AddImpresora(impresora);
        }
        private static void ListarAllImpresoras()
        {
            var impresora = _repoImpresora.GetAllImpresoras();
            foreach(Impresora i in impresora){
            Console.WriteLine(i.PlacaInventario+" "+i.Modelo);
            }
        }
    }
}
