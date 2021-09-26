using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioHistoriaClinica
    {
         // CRUD

        // Agregar HistoriaClinica
        public HistoriaClinica AgregarHistoriaClinica(HistoriaClinica historiaclinica);
        // Editar HistoriaClinica
        public HistoriaClinica EditarHistoriaClinica(HistoriaClinica historiaclinica);
        // Eliminar HistoriaClinica
        public void EliminarHistoriaClinica(int idHistoriaClinica);
        // ObtenerHistoriaClinica
        public HistoriaClinica ObtenerHistoriaClinica(int idHistoriaClinica);
        // Obtener Todas las HistoriaClinica
        public IEnumerable<HistoriaClinica> ObtenerTodaslasHistoriaClinica();
    }
}