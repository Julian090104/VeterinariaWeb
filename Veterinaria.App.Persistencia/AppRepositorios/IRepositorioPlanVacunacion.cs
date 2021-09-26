using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioPlanVacunacion
    {
         // CRUD

        // Agregar PlanVacunacion
        public PlanVacunacion AgregarPlanVacunacion(PlanVacunacion planvacunacion);
        // Editar PlanVacunacion
        public PlanVacunacion EditarPlanVacunacion(PlanVacunacion planvacunacion);
        // Eliminar PlanVacunacion
        public void EliminarPlanVacunacion(int idPlanVacunacion);
        // ObtenerPlanVacunacion
        public PlanVacunacion ObtenerPlanVacunacion(int idPlanVacunacion);
        // Obtener Todos los PlanVacunacion
        public IEnumerable<PlanVacunacion> ObtenerTodoslosPlanVacunacion();
    }
}