using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext appContext;

        public RepositorioHistoriaClinica(AppContext appContext){
            this.appContext = appContext;
        }

        HistoriaClinica IRepositorioHistoriaClinica.AgregarHistoriaClinica(HistoriaClinica hc){
            var historiaclinica = this.appContext.HistoriasClinicas.Add(hc);
            this.appContext.SaveChanges();
            return null;
        }

        HistoriaClinica IRepositorioHistoriaClinica.EditarHistoriaClinica(HistoriaClinica historiaclinicaNew){

            var historiaclinicaFind = this.appContext.HistoriasClinicas.FirstOrDefault(hc => hc.Id == historiaclinicaNew.Id);

            if(historiaclinicaFind != null){

                historiaclinicaFind.ContenidoHistoriaClinica =  historiaclinicaNew.ContenidoHistoriaClinica;
                historiaclinicaFind.FechaHistoriaClinica =  historiaclinicaNew.FechaHistoriaClinica;
                historiaclinicaFind.IdAnimal =  historiaclinicaNew.IdAnimal;
                historiaclinicaFind.IdDiagnostico =  historiaclinicaNew.IdDiagnostico;               
                this.appContext.SaveChanges();
            }
            return null;
        }

        HistoriaClinica  IRepositorioHistoriaClinica.ObtenerHistoriaClinica(int idHistoriaClinica){
            return this.appContext.HistoriasClinicas.FirstOrDefault(hc => hc.Id == idHistoriaClinica);
        }

        void IRepositorioHistoriaClinica.EliminarHistoriaClinica(int idHistoriaClinica){

            var eliminar = this.appContext.HistoriasClinicas.FirstOrDefault(hc => hc.Id == idHistoriaClinica);

            if(eliminar != null){
                this.appContext.HistoriasClinicas.Remove(eliminar);
                this.appContext.SaveChanges();
            }

        }

        IEnumerable<HistoriaClinica> IRepositorioHistoriaClinica.ObtenerTodaslasHistoriaClinica(){
            return this.appContext.HistoriasClinicas;
        }

    }
}