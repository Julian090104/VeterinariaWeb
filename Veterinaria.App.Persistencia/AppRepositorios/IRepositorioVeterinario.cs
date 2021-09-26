using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioVeterinario{

        // CRUD

        // Agregar Veterinario
        public Veterinario AgregarVeterinario(Veterinario veterinario);
        // Editar Veterinario
        public Veterinario EditarVeterinario(Veterinario veterinario);
        // Eliminar Veterinario
        public void EliminarVeterinario(int idVeterinario);
        // ObtenerVeterinario
        public Veterinario ObtenerVeterinario(int idVeterinario);
        // Obtener Todos los Veterinarios
        public IEnumerable<Veterinario> ObtenerTodoslosVeterinarios();
    }
}