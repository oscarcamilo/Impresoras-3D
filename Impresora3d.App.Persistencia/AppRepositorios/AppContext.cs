using Microsoft.EntityFrameworkCore;
using Impresora3d.App.Dominio;
using System;


namespace Impresora3d.App.Persistencia

{
    public class AppContext : DbContext
    {
        public DbSet<Impresora> Impresoras { get; set; }
        public DbSet<Operario> Operarios { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Revision> Revisiones { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Repuesto> Repuestos { get; set; }
        public DbSet<Auxiliar> Auxiliares { get; set; }
        public DbSet<JefeOperaciones> Jefes { get; set; }
        public DbSet<SocioEmpresa> Socios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Impresora3dData;Trusted_Connection=True;Persist Security Info=False");
            //optionsBuilder.UseSqlServer("Server=tcp:misiontic2022.database.windows.net,1433;Initial Catalog=HospiEncasatData;Persist Security Info=False;User ID=admin_01;Password=09122006_Hf;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=MascotaFelizBD;Trusted_Connection=True;");
        }
    }
    }
}