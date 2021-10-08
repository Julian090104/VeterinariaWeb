using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Presentacion.Pages
{
    public class PageAnimalModel : PageModel
    {

        private static IRepositorioAnimal repoAnimal = new RepositorioAnimal(new Persistencia.AppContext());

        public IEnumerable<Animal> listaMascotas;
        public void OnGet()
        {
            /* this.listaMascotas.Add(
                new Animal{
                    Nombre = "Firulais", Edad = 12, IdPlanVacunacion = 1, IdDueno = 2, IdVeterinario = 6, IdVacuna = 3
                }
            ); */
            this.listaMascotas = repoAnimal.ObtenerTodoslosAnimales();
        }

        
    }
    /* public class Animal{

        public string Nombre {get; set;}
        public int Edad {get; set;}
        public int IdPlanVacunacion {get; set;}
        public int IdDueno {get; set;}
        public int IdVeterinario {get; set;}
        public int IdVacuna {get; set;} 

    } */
}
