using Veterinaria.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;


namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioCita
    {
           // CRUD

        // Agregar Cita
        public Cita AgregarCita(Cita cita);
        // Editar Cita
        public Cita EditarCita(Cita cita);
        // Eliminar Cita
        public void EliminarCita(int idCita);
        // ObtenerCita
        public Cita ObtenerCita(int idCita);
        // Obtener Todos los Cita
        public IEnumerable<Cita> ObtenerTodaslasCita();
    }
}