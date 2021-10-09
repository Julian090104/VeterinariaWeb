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
    public class PageAdministradorModel : PageModel
    {

        private static IRepositorioAdministrador repoAdministrador = new RepositorioAdministrador(new Veterinaria.App.Persistencia.AppContext());
        public IEnumerable <Administrador> listaAdministrador;

        public void OnGet()
        {
            this.listaAdministrador = repoAdministrador.ObtenerTodoslosAdministrador();
        }
        public void OnPostAdd(Administrador administrador){
            repoAdministrador.AgregarAdministrador(administrador);
            this.listaAdministrador = repoAdministrador.ObtenerTodoslosAdministrador();
        }
        public void OnPostDel(int idAdministrador){
            repoAdministrador.EliminarAdministrador(idAdministrador);
            this.listaAdministrador = repoAdministrador.ObtenerTodoslosAdministrador();
            }
        public void OnPostEdit(Administrador administrador){
            repoAdministrador.EditarAdministrador(administrador);
            this.listaAdministrador = repoAdministrador.ObtenerTodoslosAdministrador();
        }    
    }
}
