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
    public class PageVeterinarioModel : PageModel
    {
        
        private static IRepositorioVeterinario repoVeterinario = new RepositorioVeterinario(new Veterinaria.App.Persistencia.AppContext());
        public IEnumerable <Veterinario> listaVeterinario;

        public void OnGet()
        {
            this.listaVeterinario = repoVeterinario.ObtenerTodoslosVeterinarios();
        }
        public void OnPostAdd(Veterinario veterinario){
            repoVeterinario.AgregarVeterinario(veterinario);
            this.listaVeterinario = repoVeterinario.ObtenerTodoslosVeterinarios();
        }
        public void OnPostDel(int idVeterinario){
            repoVeterinario.EliminarVeterinario(idVeterinario);
            this.listaVeterinario = repoVeterinario.ObtenerTodoslosVeterinarios();
        }
        public void OnPostEdit(Veterinario veterinario){
            repoVeterinario.EditarVeterinario(veterinario);
            this.listaVeterinario = repoVeterinario.ObtenerTodoslosVeterinarios();
        }    
        
    }
}
