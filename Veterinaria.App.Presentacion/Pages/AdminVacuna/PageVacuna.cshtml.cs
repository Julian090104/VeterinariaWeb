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

        private static IRepositorioVacuna repoVacuna = new RepositorioVacuna(new Veterinaria.App.Persistencia.AppContext());
        //public List <Vacuna> listaVacunas = new List <Vacuna>();
        public IEnumerable <Vacuna> listaVacunas;
        public String modePage = "adicion";
        public Vacuna vacunaNow;
        public void OnGet(int idVacuna)
        {
            if (idVacuna > 0)
            {
                this.modePage = "edicion";
                this.vacunaNow = repoVacuna.ObtenerVacuna(idVacuna);
            }else{
                this.modePage = "adicion";
            }

            actualizarLista();
        }
        public void OnPostAdd(Vacuna vacuna){
            repoVacuna.AgregarVacuna(vacuna);
            actualizarLista();
        }
        public void OnPostDel(int idVacuna){
            repoVacuna.EliminarVacuna(idVacuna);
            actualizarLista();
        }
        public void OnPostEdit(Vacuna vacuna){
            repoVacuna.EditarVacuna(vacuna);
            actualizarLista();
        }
        public void actualizarLista(){
            this.listaVacunas = repoVacuna.ObtenerTodaslasVacunas();
        }  
    }
    
}
