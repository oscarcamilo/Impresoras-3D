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
        private static IRepositorioTecnico _repoTecnico = new RepositorioTecnico(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            //AddTecnico();
            //AddPersona();
            AddImpresora();
            //AddImpresora();
            //ListarAllImpresoras();


        }
        private static void AddPersona()
        {
            var persona = new Persona{
                Nombre = "Rosa",
                Identificacion = 2135464,
                Apellidos = "Garzon",
                NumeroTelefono = "31156986",
                FechaNacimiento = new DateTime(1997, 06, 15),
                Correo = "Rosagarz@gmail.com"
            };
            _repoPersona.AddPersona(persona);

        }
        private static void AddTecnico()
        {
            var tecnico = new Tecnico{
                Nombre = "Juan",
                Identificacion = 63145,
                Apellidos = "Gonzalez",
                NumeroTelefono = "3214568",
                FechaNacimiento = new DateTime(1999, 06, 15),
                Correo = "juanitoelpro@gmail.com",
                Direccion = "Calle 1234",
                NivelEstudio = "Basica Primaria"
            };
            _repoTecnico.AddTecnico(tecnico);

        }
        private static void AddImpresora()
        {
            var impresora = new Impresora{
                PlacaInventario = 002,
                Tipo = "Polar",
                Marca = "Ceality",
                Modelo = "Ender 3",
                PaisDeOrigen = "China",
                VolumenImpresion = "22X22",
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
