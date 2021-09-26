using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioAdministrador 
    {
         // CRUD

        // Agregar Administrador
        public Administrador AgregarAdministrador(Administrador administrador);
        // Editar Administrador
        public Administrador EditarAdministrador(Administrador administrador);
        // Eliminar Administrador
        public void EliminarAdministrador(int idAdministrador);
        // ObtenerAdministrador
        public Administrador ObtenerAdministrador(int idAdministrador);
        // Obtener Todos los Administrador
        public IEnumerable<Administrador> ObtenerTodoslosAdministrador();
    }
}