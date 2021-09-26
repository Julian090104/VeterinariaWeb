using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioDueno
    {
         // CRUD

        // Agregar Dueno
        public Dueno AgregarDueno(Dueno dueno);
        // Editar Dueno
        public Dueno EditarDueno(Dueno dueno);
        // Eliminar Dueno
        public void EliminarDueno(int idDueno);
        // ObtenerDueno
        public Dueno ObtenerDueno(int idDueno);
        // Obtener Todos los Dueno
        public IEnumerable<Dueno> ObtenerTodoslosDueno();
    }
}