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
    public class PageVacunaModel : PageModel
    {

        private static IRepositorioVacuna repoVacuna = new RepositorioVacuna(new Persistencia.AppContext());
        public IEnumerable<Vacuna> listaVacunas;

        public void OnGet()
        {
            this.listaVacunas = repoVacuna.ObtenerTodaslasVacunas();
        }
        public void OnPostAdd(Vacuna vacuna){
            repoVacuna.AgregarVacuna(vacuna);
            this.listaVacunas = repoVacuna.ObtenerTodaslasVacunas();
        }
        public void OnPostDel(int idVacuna){
            repoVacuna.EliminarVacuna(idVacuna);
            this.listaVacunas = repoVacuna.ObtenerTodaslasVacunas();
        }
        public void OnPostEdit(Vacuna vacuna){
            repoVacuna.EditarVacuna(vacuna);
            this.listaVacunas = repoVacuna.ObtenerTodaslasVacunas();
        }  
    }
    
}
