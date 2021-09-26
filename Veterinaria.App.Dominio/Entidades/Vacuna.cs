using System;

namespace Veterinaria.App.Dominio
{
    public class Vacuna
    {
        public int Id {set; get;}
        public string NombreVacuna {set; get;}
        public DateTime FechaVacuna {set; get;}
        public string Contraindicaciones {set; get;}
        public string ProteccionContra {set; get;}
    }
}