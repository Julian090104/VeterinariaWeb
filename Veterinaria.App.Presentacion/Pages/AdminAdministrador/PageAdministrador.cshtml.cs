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
        public String modePage = "adicion";
        public Administrador adminNow;

        public void OnGet(int idAdministrador)
        {
            if (idAdministrador > 0)
            {
                this.modePage = "edicion";
                this.adminNow = repoAdministrador.ObtenerAdministrador(idAdministrador);
            }else{
                this.modePage = "adicion";
            }

            actualizarLista();
            
        }
        public void OnPostAdd(Administrador administrador){
            repoAdministrador.AgregarAdministrador(administrador);
            actualizarLista();
        }
        public void OnPostDel(int idAdministrador){
            repoAdministrador.EliminarAdministrador(idAdministrador);
            actualizarLista();
        }
        public void OnPostEdit(Administrador administrador){
            repoAdministrador.EditarAdministrador(administrador);
            actualizarLista();
        }

        public void actualizarLista(){
            this.listaAdministrador = repoAdministrador.ObtenerTodoslosAdministrador();
        }    
    }
}
