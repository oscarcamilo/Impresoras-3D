using Microsoft.EntityFrameworkCore;
using Impresora3d.App.Dominio;
using System;


namespace Impresora3d.App.Persistencia

{
    public class AppContext : DbContext
    {
        public DbSet<Seguro> Seguros { get; set; }
        

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Impresora3dData");
        }
    }
    }
}