using System;
namespace Veterinaria.App.Dominio
{
    public class Animal
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public int IdPlanVacunacion {get; set;}
        public int IdDueno {get; set;}
        public int IdVeterinario {get; set;}
        public int IdVacuna {get; set;} 
    }
}