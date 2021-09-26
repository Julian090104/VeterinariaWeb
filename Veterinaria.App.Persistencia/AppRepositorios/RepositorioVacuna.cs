using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioVacuna : IRepositorioVacuna
    {
        private readonly AppContext appContext;

        public RepositorioVacuna(AppContext appContext){
            this.appContext = appContext;
        }

        Vacuna IRepositorioVacuna.AgregarVacuna(Vacuna v){
            var vacuna = this.appContext.Vacunas.Add(v);
            this.appContext.SaveChanges();
            return null;
        }

        Vacuna IRepositorioVacuna.EditarVacuna(Vacuna vacunaNew){

            var vacunaFind = this.appContext.Vacunas.FirstOrDefault(v => v.Id == vacunaNew.Id);

            if(vacunaFind != null){

                vacunaFind.NombreVacuna =  vacunaNew.NombreVacuna;
                vacunaFind.FechaVacuna =  vacunaNew.FechaVacuna;
                vacunaFind.Contraindicaciones =  vacunaNew.Contraindicaciones;
                vacunaFind.ProteccionContra =  vacunaNew.ProteccionContra;
                this.appContext.SaveChanges();
            }

            return null;
        }

        Vacuna  IRepositorioVacuna.ObtenerVacuna(int idVacuna){
            return this.appContext.Vacunas.FirstOrDefault(v => v.Id == idVacuna);
        }

        void IRepositorioVacuna.EliminarVacuna(int idVacuna){

            var eliminar = this.appContext.Vacunas.FirstOrDefault(v => v.Id == idVacuna);

            if(eliminar != null){
                this.appContext.Vacunas.Remove(eliminar);
                this.appContext.SaveChanges();
            }

        }

        IEnumerable<Vacuna> IRepositorioVacuna.ObtenerTodaslasVacunas(){
            return null;
        }

    }
}