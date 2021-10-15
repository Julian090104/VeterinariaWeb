using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioAdministrador : IRepositorioAdministrador
    {
        private readonly AppContext appContext;

        public RepositorioAdministrador(AppContext appContext){
            this.appContext = appContext;
        }

        Administrador IRepositorioAdministrador.AgregarAdministrador(Administrador a){
            var administrador = this.appContext.Administradores.Add(a);
            this.appContext.SaveChanges();
            return null;
        }

        Administrador IRepositorioAdministrador.EditarAdministrador(Administrador administradorNew){

            var administradorFind = this.appContext.Administradores.FirstOrDefault(a => a.Id == administradorNew.Id);
            
            if(administradorFind != null){
                administradorFind.Nombre = administradorNew.Nombre;
                administradorFind.Telefono = administradorNew.Telefono;
                administradorFind.FechaNacimiento = administradorNew.FechaNacimiento;
                administradorFind.Edad = administradorNew.Edad;
                administradorFind.Direccion = administradorNew.Direccion;
                administradorFind.Correo = administradorNew.Correo;    
                this.appContext.SaveChanges();
            }
            return null;
        }

        Administrador  IRepositorioAdministrador.ObtenerAdministrador(int idAdministrador){
            return this.appContext.Administradores.FirstOrDefault(a => a.Id == idAdministrador);
        }

        void IRepositorioAdministrador.EliminarAdministrador(int idAdministrador){

            var eliminar = this.appContext.Administradores.FirstOrDefault(a => a.Id == idAdministrador);

            if(eliminar != null){
                this.appContext.Administradores.Remove(eliminar);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable<Administrador> IRepositorioAdministrador.ObtenerTodoslosAdministrador(){
            return this.appContext.Administradores;
        }

    }
}