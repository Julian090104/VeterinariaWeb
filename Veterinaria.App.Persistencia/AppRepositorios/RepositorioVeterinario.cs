using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia{
 
    public class RepositorioVeterinario : IRepositorioVeterinario { 

        private readonly AppContext appContext;

        public RepositorioVeterinario(AppContext appContext){
            this.appContext = appContext;
        }

        Veterinario IRepositorioVeterinario.AgregarVeterinario(Veterinario v){
            var veterinario = this.appContext.Veterinarios.Add(v);
            this.appContext.SaveChanges();
            return null;
        }

        Veterinario IRepositorioVeterinario.ObtenerVeterinario(int idVeterinario){
            return this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
        }

       
        Veterinario IRepositorioVeterinario.EditarVeterinario(Veterinario veterinarioNew){

            var veterinarioFind = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioNew.Id);

            if(veterinarioFind != null){

                veterinarioFind.Nombre = veterinarioNew.Nombre;
                veterinarioFind.Telefono = veterinarioNew.Telefono;
                veterinarioFind.Edad = veterinarioNew.Edad;
                veterinarioFind.Direccion = veterinarioNew.Direccion;
                veterinarioFind.Correo = veterinarioNew.Correo;
                veterinarioFind.Especializacion = veterinarioNew.Especializacion;
                veterinarioFind.TarjetaProfesional = veterinarioNew.TarjetaProfesional;
                veterinarioFind.FechaNacimiento = veterinarioNew.FechaNacimiento;
                this.appContext.SaveChanges();

            }

            return null;
        }
        
        void IRepositorioVeterinario.EliminarVeterinario(int idVeterinario){
            var eliminado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
            if(eliminado != null){
                this.appContext.Veterinarios.Remove(eliminado);
                this.appContext.SaveChanges();
            }
        }
    
        IEnumerable<Veterinario> IRepositorioVeterinario.ObtenerTodoslosVeterinarios(){
            return null;
        }
         
    }
}