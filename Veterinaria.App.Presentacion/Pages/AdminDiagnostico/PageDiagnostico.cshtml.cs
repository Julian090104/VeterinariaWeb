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
    public class PageDiagnosticoModel : PageModel
    {
        private static IRepositorioDiagnostico repoDiagnostico = new RepositorioDiagnostico(new Persistencia.AppContext());
        public IEnumerable<Diagnostico> listaDiagnosticos;
        public Diagnostico diagnosticoNow;
        public String modePage = "adicion";
        public void OnGet(int idDiagnostico)
        {
             if (idDiagnostico > 0)
            {
                this.modePage = "edicion";
                this.diagnosticoNow = repoDiagnostico.ObtenerDiagnostico(idDiagnostico);
            }else{
                this.modePage = "adicion";
            }

            actualizarLista();
        }

        public void OnPostAdd(Diagnostico diagnostico){
            repoDiagnostico.AgregarDiagnostico(diagnostico);
            actualizarLista();
        }
        public void OnPostDel(int idDiagnostico){
            repoDiagnostico.EliminarDiagnostico(idDiagnostico);
            actualizarLista();
        }
        public void OnPostEdit(Diagnostico diagnostico){
            repoDiagnostico.EditarDiagnostico(diagnostico);
            actualizarLista();
        } 

        public void actualizarLista(){
            this.listaDiagnosticos = repoDiagnostico.ObtenerTodoslosDiagnosticos();
        } 
    }
}
