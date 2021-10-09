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
    public class AdDuenoModel : PageModel
    {
        private static IRepositorioDueno repoDueno = new RepositorioDueno(new Veterinaria.App.Persistencia.AppContext());
        public IEnumerable <Dueno> listaDueno;

        public void OnGet()
        {
            this.listaDueno = repoDueno.ObtenerTodoslosDueno();
        }
        public void OnPostAdd(Dueno dueno){
            repoDueno.AgregarDueno(dueno);
            this.listaDueno = repoDueno.ObtenerTodoslosDueno();
        }
        public void OnPostDel(int idDueno){
            repoDueno.EliminarDueno(idDueno);
            this.listaDueno = repoDueno.ObtenerTodoslosDueno();
        }
        public void OnPostEdit(Dueno dueno){
            repoDueno.EditarDueno(dueno);
            this.listaDueno = repoDueno.ObtenerTodoslosDueno();
        }
    }
    
}
