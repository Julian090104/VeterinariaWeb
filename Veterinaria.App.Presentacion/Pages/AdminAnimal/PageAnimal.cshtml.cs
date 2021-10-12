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
            this.listaMascotas = repoAnimal.ObtenerTodoslosAnimales();
        }

    public void OnPostAdd(Animal animal){
            repoAnimal.AgregarAnimal(animal);
            this.listaMascotas = repoAnimal.ObtenerTodoslosAnimales();
        }
        public void OnPostDel(int idAnimal){
            repoAnimal.EliminarAnimal(idAnimal);
            this.listaMascotas = repoAnimal.ObtenerTodoslosAnimales();
        }
        public void OnPostEdit(Animal animal){
            repoAnimal.EditarAnimal(animal);
            this.listaMascotas = repoAnimal.ObtenerTodoslosAnimales();
        }  
        
    }
   
}
