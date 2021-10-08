using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioPlanVacunacion : IRepositorioPlanVacunacion
    {
        private readonly AppContext appContext;

        public RepositorioPlanVacunacion(AppContext appContext){
            this.appContext = appContext;
        }

        PlanVacunacion IRepositorioPlanVacunacion.AgregarPlanVacunacion(PlanVacunacion pv){
            var planvacunacion = this.appContext.PlanesVacunaciones.Add(pv);
            this.appContext.SaveChanges();
            return null;
        }

        PlanVacunacion IRepositorioPlanVacunacion.EditarPlanVacunacion(PlanVacunacion planvacunacionNew){

            var planvacunacionFind = this.appContext.PlanesVacunaciones.FirstOrDefault(pv => pv.Id == planvacunacionNew.Id);

            if(planvacunacionFind != null){

                planvacunacionFind.Nombre =  planvacunacionNew.Nombre;
                planvacunacionFind.Descripcion =  planvacunacionNew.Descripcion;                               
                this.appContext.SaveChanges();

            }

            return null;
        }

        PlanVacunacion  IRepositorioPlanVacunacion.ObtenerPlanVacunacion(int idPlanVacunacion){
            return this.appContext.PlanesVacunaciones.FirstOrDefault(pv => pv.Id == idPlanVacunacion);
        }

        void IRepositorioPlanVacunacion.EliminarPlanVacunacion(int idPlanVacunacion){

            var eliminar = this.appContext.PlanesVacunaciones.FirstOrDefault(pv => pv.Id == idPlanVacunacion);

            if(eliminar != null){
                this.appContext.PlanesVacunaciones.Remove(eliminar);
                this.appContext.SaveChanges();
            }

        }

        IEnumerable<PlanVacunacion> IRepositorioPlanVacunacion.ObtenerTodoslosPlanVacunacion(){
            return this.appContext.PlanesVacunaciones;
        }

    }
}