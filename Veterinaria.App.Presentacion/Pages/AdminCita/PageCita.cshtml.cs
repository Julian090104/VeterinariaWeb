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
    public class PageCitaModel : PageModel
    {
        private static IRepositorioCita repoCita = new RepositorioCita(new Persistencia.AppContext());
        public IEnumerable<Cita> listaCitas;

        public void OnGet()
        {
            this.listaCitas = repoCita.ObtenerTodaslasCita();
        }
    }

    
}

