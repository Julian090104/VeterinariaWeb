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
        public void OnGet()
        {
            this.listaDiagnosticos = repoDiagnostico.ObtenerTodoslosDiagnosticos();
        }

        public void OnPostAdd(Diagnostico diagnostico){
            repoDiagnostico.AgregarDiagnostico(diagnostico);
            this.listaDiagnosticos = repoDiagnostico.ObtenerTodoslosDiagnosticos();
        }
        public void OnPostDel(int idDiagnostico){
            repoDiagnostico.EliminarDiagnostico(idDiagnostico);
            this.listaDiagnosticos = repoDiagnostico.ObtenerTodoslosDiagnosticos();
        }
        public void OnPostEdit(Diagnostico diagnostico){
            repoDiagnostico.EditarDiagnostico(diagnostico);
            this.listaDiagnosticos = repoDiagnostico.ObtenerTodoslosDiagnosticos();
        }  
    }
}
