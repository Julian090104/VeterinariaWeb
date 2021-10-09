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
    public class AdHistoriaClinicaModel : PageModel
    {
        // public List <HistoriaClinica> listaAdHistoriaC = new List <HistoriaClinica>();
        private static IRepositorioHistoriaClinica repoHistoriaClinica = new RepositorioHistoriaClinica(new Veterinaria.App.Persistencia.AppContext());
        public IEnumerable <HistoriaClinica> listaHistoriaClinica;

        public void OnGet()
        {
            // this.listaAdHistoriaC.Add(
            //     new HistoriaClinica{
            //         ContenidoHistoriaClinica = "Sintomas de intoxicación", FechaHistoriaClinica = new DateTime(2021, 03, 03), IdAnimal = 1, IdDiagnostico = 1
            //     }
            // );
            this.listaHistoriaClinica = repoHistoriaClinica.ObtenerTodaslasHistoriaClinica();
        }
        public void OnPostAdd(HistoriaClinica historiaclinica){
            repoHistoriaClinica.AgregarHistoriaClinica(historiaclinica);
            this.listaHistoriaClinica = repoHistoriaClinica.ObtenerTodaslasHistoriaClinica();
        }
        public void OnPostDel(int idHistoriaClinica){
            repoHistoriaClinica.EliminarHistoriaClinica(idHistoriaClinica);
            this.listaHistoriaClinica = repoHistoriaClinica.ObtenerTodaslasHistoriaClinica();
        }
        public void OnPostEdit(HistoriaClinica historiaclinica){
            repoHistoriaClinica.EditarHistoriaClinica(historiaclinica);
            this.listaHistoriaClinica = repoHistoriaClinica.ObtenerTodaslasHistoriaClinica();
        }
    }
    
}
