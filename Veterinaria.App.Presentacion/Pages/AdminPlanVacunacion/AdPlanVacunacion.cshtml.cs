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
        private static IRepositorioPlanVacunacion repoPlanVacunacion = new RepositorioPlanVacunacion(new Veterinaria.App.Persistencia.AppContext());
        public IEnumerable <PlanVacunacion> listaPlanVacunacion;
        public string modePage = "adicion";
        public PlanVacunacion planNow;
        public void OnGet(int idPlanVacunacion)
        {
            if (idPlanVacunacion > 0)
            {
                this.modePage = "edicion";
                this.planNow = repoPlanVacunacion.ObtenerPlanVacunacion(idPlanVacunacion);
            }else{
                this.modePage = "adicion";
            }

            actualizarLista();
            
        }
        public void OnPostAdd(PlanVacunacion planvacunacion){
            repoPlanVacunacion.AgregarPlanVacunacion(planvacunacion);
            actualizarLista();
        }
        public void OnPostDel(int idPlanVacunacion){
            repoPlanVacunacion.EliminarPlanVacunacion(idPlanVacunacion);
            actualizarLista();
        }
        public void OnPostEdit(PlanVacunacion planvacunacion){
            repoPlanVacunacion.EditarPlanVacunacion(planvacunacion);
           actualizarLista();
        }

        public void actualizarLista(){
            this.listaPlanVacunacion = repoPlanVacunacion.ObtenerTodoslosPlanVacunacion();
        }    
    }
    
    
}
