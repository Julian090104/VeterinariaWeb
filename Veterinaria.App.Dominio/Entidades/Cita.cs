using System;

namespace Veterinaria.App.Dominio
{
    public class Cita
    {
        public int Id {get; set;}
        public DateTime FechaCita {get; set;}
        public string TipoConsulta {get; set;}
        public string MotivoConsulta {get; set;}
        public int IdDueno {get; set;}
        public int IdVeterinario {get; set;} 
    }
}