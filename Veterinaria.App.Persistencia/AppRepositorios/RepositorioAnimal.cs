using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioAnimal : IRepositorioAnimal
    {
        private readonly AppContext appContext;

        public RepositorioAnimal(AppContext appContext){
            this.appContext = appContext;
        }

        Animal IRepositorioAnimal.AgregarAnimal(Animal a){
            var animal = this.appContext.Animales.Add(a);
            this.appContext.SaveChanges();
            return null;
        }

        Animal IRepositorioAnimal.EditarAnimal(Animal animalNew){

            var animalFind = this.appContext.Animales.FirstOrDefault(a => a.Id == animalNew.Id);

            if(animalFind != null){

                animalFind.Nombre =  animalNew.Nombre;
                animalFind.Edad =  animalNew.Edad;
                animalFind.IdPlanVacunacion=  animalNew.IdPlanVacunacion;
                animalFind.IdDueno =  animalNew.IdDueno;
                animalFind.IdVeterinario =  animalNew.IdVeterinario;
                animalFind.IdVacuna =  animalNew.IdVacuna;
                               
                this.appContext.SaveChanges();

            }

            return null;
        }

        Animal  IRepositorioAnimal.ObtenerAnimal(int idAnimal){
            return this.appContext.Animales.FirstOrDefault(a => a.Id == idAnimal);
        }

        void IRepositorioAnimal.EliminarAnimal(int idAnimal){

            var eliminar = this.appContext.Animales.FirstOrDefault(a => a.Id == idAnimal);

            if(eliminar != null){
                this.appContext.Animales.Remove(eliminar);
                this.appContext.SaveChanges();
            }

        }

        IEnumerable<Animal> IRepositorioAnimal.ObtenerTodoslosAnimales(){
            return null;
        }

    }
}