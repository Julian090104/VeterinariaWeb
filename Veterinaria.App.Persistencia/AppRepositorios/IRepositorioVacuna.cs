using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioVacuna
    {
         // CRUD

        // Agregar Vacuna
        public Vacuna AgregarVacuna(Vacuna vacuna);
        // Editar Vacuna
        public Vacuna EditarVacuna(Vacuna vacuna);
        // Eliminar Vacuna
        public void EliminarVacuna(int idVacuna);
        // ObtenerVacuna
        public Vacuna ObtenerVacuna(int idVacuna);
        // Obtener Todas las Vacunas
        public IEnumerable<Vacuna> ObtenerTodaslasVacunas();
    }
}