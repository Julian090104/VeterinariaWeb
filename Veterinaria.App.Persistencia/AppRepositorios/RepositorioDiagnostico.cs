using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioDiagnostico : IRepositorioDiagnostico
    {
        private readonly AppContext appContext;

        public RepositorioDiagnostico(AppContext appContext){
            this.appContext = appContext;
        }

        Diagnostico IRepositorioDiagnostico.AgregarDiagnostico(Diagnostico d){
            var diagnostico = this.appContext.Diagnosticos.Add(d);
            this.appContext.SaveChanges();
            return null;
        }

        Diagnostico IRepositorioDiagnostico.EditarDiagnostico(Diagnostico diagnosticoNew){

            var diagnosticoFind = this.appContext.Diagnosticos.FirstOrDefault(d => d.Id == diagnosticoNew.Id);

            if(diagnosticoFind != null){

                diagnosticoFind.TipoDiagnostico = diagnosticoNew.TipoDiagnostico;
                diagnosticoFind.NombreDiagnostico =  diagnosticoNew.NombreDiagnostico;
                diagnosticoFind.DescripcionDiagnostico = diagnosticoNew.DescripcionDiagnostico;
                
                this.appContext.SaveChanges();

            }

            return null;
        }

        Diagnostico IRepositorioDiagnostico.ObtenerDiagnostico(int idDiagnostico){
            return this.appContext.Diagnosticos.FirstOrDefault(d => d.Id == idDiagnostico);
        }

        void IRepositorioDiagnostico.EliminarDiagnostico(int idDiagnostico){

            var eliminar = this.appContext.Diagnosticos.FirstOrDefault(a => a.Id == idDiagnostico);

            if(eliminar != null){
                this.appContext.Diagnosticos.Remove(eliminar);
                this.appContext.SaveChanges();
            }

        }

        IEnumerable<Diagnostico> IRepositorioDiagnostico.ObtenerTodoslosDiagnosticos(){
            return null;
        }
        
    }
}