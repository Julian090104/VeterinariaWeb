using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioAnimal
    {
         // CRUD

        // Agregar Animal
        public Animal AgregarAnimal(Animal animal);
        // Editar Animal
        public Animal EditarAnimal(Animal animal);
        // Eliminar Animal
        public void EliminarAnimal(int idAnimal);
        // ObtenerAnimal
        public Animal ObtenerAnimal(int idAnimal);
        // Obtener Todos los Animals
        public IEnumerable<Animal> ObtenerTodoslosAnimales();
    }
}