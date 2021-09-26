using System;

namespace Veterinaria.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id {get; set;}
        public string ContenidoHistoriaClinica {set; get;}
        public DateTime FechaHistoriaClinica {set; get;}
        public int IdAnimal {get; set;}
        public int IdDiagnostico {set; get;}
    }
}