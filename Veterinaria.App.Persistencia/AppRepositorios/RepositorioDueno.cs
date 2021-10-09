using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioDueno : IRepositorioDueno
    {
        private readonly AppContext appContext;

        public RepositorioDueno(AppContext appContext){
            this.appContext = appContext;
        }

        Dueno IRepositorioDueno.AgregarDueno(Dueno d){
            var dueno = this.appContext.Duenos.Add(d);
            this.appContext.SaveChanges();
            return null;
        }

        Dueno IRepositorioDueno.EditarDueno(Dueno duenoNew){

            var duenoFind = this.appContext.Duenos.FirstOrDefault(d => d.Id == duenoNew.Id);

            if(duenoFind != null){
                duenoFind.Nombre = duenoNew.Nombre;
                duenoFind.Telefono = duenoNew.Telefono;
                duenoFind.Edad = duenoNew.Edad;
                duenoFind.Direccion = duenoNew.Direccion;
                duenoFind.Correo = duenoNew.Correo;
                duenoFind.Contrasena = duenoNew.Contrasena;       
                this.appContext.SaveChanges();
            }
            return null;
        }

        Dueno  IRepositorioDueno.ObtenerDueno(int idDueno){
            return this.appContext.Duenos.FirstOrDefault(d => d.Id == idDueno);
        }

        void IRepositorioDueno.EliminarDueno(int idDueno){

            var eliminar = this.appContext.Duenos.FirstOrDefault(d => d.Id == idDueno);

            if(eliminar != null){
                this.appContext.Duenos.Remove(eliminar);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable<Dueno> IRepositorioDueno.ObtenerTodoslosDueno(){
            /* return this.appContext.Personas.Where(d => d.Discriminator == Dueno); */
            foreach(var e in this.appContext.Duenos){
                Console.WriteLine(e);
            }
            return null;
        }
    }
}