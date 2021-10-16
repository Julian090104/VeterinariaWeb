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
        public String modePage = "adicion";
        public Dueno duenoNow;

        public void OnGet(int idDueno)
        {
            if (idDueno > 0)
            {
                this.modePage = "edicion";
                this.duenoNow = repoDueno.ObtenerDueno(idDueno);
            }else{
                this.modePage = "adicion";
            }

            actualizarLista();
        }
        public void OnPostAdd(Dueno dueno){
            repoDueno.AgregarDueno(dueno);
            actualizarLista();
        }
        public void OnPostDel(int idDueno){
            repoDueno.EliminarDueno(idDueno);
            actualizarLista();
        }
        public void OnPostEdit(Dueno dueno){
            repoDueno.EditarDueno(dueno);
            actualizarLista();
        }
        public void actualizarLista(){
            this.listaDueno = repoDueno.ObtenerTodoslosDueno();
        } 
    }
    
}
