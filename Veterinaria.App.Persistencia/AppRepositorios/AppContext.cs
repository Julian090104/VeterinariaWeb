using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{
    
    public class AppContext: DbContext{

        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Dueno> Duenos { get; set; }
        public DbSet<Animal> Animales { get;set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Diagnostico> Diagnosticos {get; set;}
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Cita> Citas {get; set;}
        public DbSet<PlanVacunacion> PlanesVacunaciones { get; set; }
        public DbSet<Vacuna> Vacunas { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = VeterinariaOctubre");
            
            }
        }        

    }                
}

