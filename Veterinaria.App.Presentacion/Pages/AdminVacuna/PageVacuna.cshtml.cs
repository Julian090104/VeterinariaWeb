using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public List<SelectListItem> Vacunas { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Distempoer", Text = "Distempoer" },
            new SelectListItem { Value = "Parvovirus", Text = "Parvovirus" },
            new SelectListItem { Value = "Hepatitis Infecciosa Canina", Text = "Hepatitis Infecciosa Canina"  },
        };

        public Vacuna vacuna;
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
