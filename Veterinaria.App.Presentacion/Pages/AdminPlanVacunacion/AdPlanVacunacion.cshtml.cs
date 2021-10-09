using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;

namespace Veterianaria.App.Presentacion.Pages
{
    public class AdPlanVacunacionModel : PageModel
    {
        //public List <PlanVacunacion> listaAdPlanVacunaciones = new List <PlanVacunacion>();
        private static IRepositorioPlanVacunacion repoPlanVacuna = new RepositorioPlanVacunacion(new Veterinaria.App.Persistencia.AppContext());
        public IEnumerable <PlanVacunacion> listaPlanVacuna;
        public void OnGet()
        {
            // this.listaPlanVacuna.Add(
            //     new PlanVacunacion{
            //         Nombre = "Plan Nacional", Descripcion = "Plan Nacional contra la Rabia"
            //     }
            // );
            this.listaPlanVacuna = repoPlanVacuna.ObtenerTodoslosPlanVacunacion();
        }
        public void OnPostAdd(PlanVacunacion planvacunacion){
            repoPlanVacuna.AgregarPlanVacunacion(planvacunacion);
            this.listaPlanVacuna = repoPlanVacuna.ObtenerTodoslosPlanVacunacion();
        }
        public void OnPostDel(int idPlanVacunacion){
            repoPlanVacuna.EliminarPlanVacunacion(idPlanVacunacion);
            this.listaPlanVacuna = repoPlanVacuna.ObtenerTodoslosPlanVacunacion();
        }
        public void OnPostEdit(PlanVacunacion planvacunacion){
            repoPlanVacuna.EditarPlanVacunacion(planvacunacion);
            this.listaPlanVacuna = repoPlanVacuna.ObtenerTodoslosPlanVacunacion();
        }
    }
    
}
