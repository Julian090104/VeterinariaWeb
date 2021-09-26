using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioDiagnostico
    {
         
          // CRUD

        // Agregar Diagnostico
        public Diagnostico AgregarDiagnostico(Diagnostico diagnostico);
        // Editar Diagnostico
        public Diagnostico EditarDiagnostico(Diagnostico diagnostico);
        // Eliminar Diagnostico
        public void EliminarDiagnostico(int idDiagnostico);
        // ObtenerDiagnostico
        public Diagnostico ObtenerDiagnostico(int idDiagnostico);
        // Obtener Todos los Diagnosticos
        public IEnumerable<Diagnostico> ObtenerTodoslosDiagnosticos();

    }
}