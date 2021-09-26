using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Veterinaria.App.Persistencia
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly AppContext appContext;

        public RepositorioCita(AppContext appContext){
            this.appContext = appContext;
        }

        Cita IRepositorioCita.AgregarCita(Cita c){
            var cita = this.appContext.Citas.Add(c);
            this.appContext.SaveChanges();
            return null;
        }

        Cita IRepositorioCita.EditarCita(Cita citaNew){
            
            var citaFind = this.appContext.Citas.FirstOrDefault(c => c.Id == citaNew.Id);

            if(citaFind != null){

                citaFind.FechaCita = citaNew.FechaCita;
                citaFind.TipoConsulta =  citaNew.TipoConsulta;
                citaFind.MotivoConsulta = citaNew.MotivoConsulta;
                citaFind.IdDueno = citaNew.IdDueno;
                citaFind.IdVeterinario = citaNew.IdVeterinario;
                
                this.appContext.SaveChanges();

            }

            return null;
        }

        Cita IRepositorioCita.ObtenerCita(int idCita){
            return this.appContext.Citas.FirstOrDefault(c => c.Id == idCita);
        }

        void IRepositorioCita.EliminarCita(int idCita){

            var eliminar = this.appContext.Citas.FirstOrDefault(c => c.Id == idCita);

            if(eliminar != null){
                this.appContext.Citas.Remove(eliminar);
                this.appContext.SaveChanges();
            }

        }

        IEnumerable<Cita> IRepositorioCita.ObtenerTodaslasCita(){
            return null;
        }
    }
}