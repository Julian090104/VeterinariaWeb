using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {

        private static IRepositorioVeterinario repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioAnimal repoAnimal = new RepositorioAnimal(new Persistencia.AppContext());
        private static IRepositorioDiagnostico repoDiagnostico = new RepositorioDiagnostico(new Persistencia.AppContext());
        private static IRepositorioVacuna repoVacuna = new RepositorioVacuna(new Persistencia.AppContext());

        static void Main(string[] args)
        {  
            //AgregarVacuna();
            //BuscarVacuna(1);
            //EditarVacuna();
           //EliminarVacuna(2);

            //AgregarDiagnostico();
            //BuscarDiagnostico(1);
            //EditarDiagnostico();
            //EliminarDiagnostico(1);

            //AgregarAnimal();
            //BuscarAnimal(2);
            //EditarAnimal();
            //EliminarAnimal(1);

            //AgregarVeterinario();
            //EliminarVeterinario(2);
            //EditarVeterinario();
            //BuscarVeterinario(1);
            //Console.WriteLine("Hello World!");
        }

        private static void AgregarVacuna(){
            var vacuna = new Vacuna{
                NombreVacuna = "Papiloma",
                FechaVacuna = new DateTime(2021, 01, 01),
                Contraindicaciones = "Licor",
                ProteccionContra = "El Papiloma Humano"
            };
            repoVacuna.AgregarVacuna(vacuna);
        }

        private static void BuscarVacuna(int idVacuna){
            var vacuna = repoVacuna.ObtenerVacuna(idVacuna);
            Console.WriteLine("el nombre de la vacuna es: " + vacuna.NombreVacuna);
        }

        private static void EditarVacuna(){
            var vacuna = new Vacuna{
                Id = 1,
                NombreVacuna = "Papiloma",
                FechaVacuna = new DateTime(2021, 05, 01),
                Contraindicaciones = "Bebidas Alcoholicas",
                ProteccionContra = "El Papiloma Humano"
            };

            repoVacuna.EditarVacuna(vacuna);
        }

        private static void EliminarVacuna(int idVacuna){
            repoVacuna.EliminarVacuna(idVacuna);
        } 

        private static void AgregarDiagnostico(){
            var diagnostico = new Diagnostico{
                TipoDiagnostico = "Quirurjico",
                NombreDiagnostico = "Tumor en el colon",
                DescripcionDiagnostico = "El animal presenta dolores fuertes en el abdomen"
            };
            repoDiagnostico.AgregarDiagnostico(diagnostico);
        }

        private static void BuscarDiagnostico(int idDiagnostico){
            var diagnostico = repoDiagnostico.ObtenerDiagnostico(idDiagnostico);
            Console.WriteLine("el nombre del diagnostico es: " + diagnostico.NombreDiagnostico);
        }

        private static void EditarDiagnostico(){
            var diagnostico = new Diagnostico{
                Id = 1,
                TipoDiagnostico = "Otitis",
                NombreDiagnostico = "Inflamación Oido",
                DescripcionDiagnostico = "El animal presenta sintoamtologia de inflacion en el oido izquierdo, por lo que hace una revision y efectivamente se encontró"
            };
            repoDiagnostico.EditarDiagnostico(diagnostico);
        }

        private static void EliminarDiagnostico(int idDiagnostico){
            repoDiagnostico.EliminarDiagnostico(idDiagnostico);
        } 


        private static void AgregarAnimal(){
            var animal = new Animal{
                Nombre = "Marina",
                Edad = 5,
                IdPlanVacunacion = 2,
                IdDueno = 2,
                IdVeterinario = 3,
                IdVacuna = 2
            };
            repoAnimal.AgregarAnimal(animal);
        }

        private static void BuscarAnimal(int idAnimal){
            var animal = repoAnimal.ObtenerAnimal(idAnimal);
            Console.WriteLine("el nombre del animal es: " + animal.Nombre);
        }

        private static void EditarAnimal(){
            var animal = new Animal{
                Id = 1,
                Nombre = "Lucas",
                Edad = 8,
                IdPlanVacunacion = 7,
                IdDueno = 1,
                IdVeterinario = 3,
                IdVacuna = 9
            };

            repoAnimal.EditarAnimal(animal);
        }

        private static void EliminarAnimal(int idAnimal){
            repoAnimal.EliminarAnimal(idAnimal);
        } 

        private static void AgregarVeterinario(){
            var veterinario = new Veterinario{
                Nombre = "Julian Rivera Castaño",
                Telefono = "301764132",
                Edad = 32,
                Direccion = "Cra 23 #34-34",
                Correo = "julianri@gmail.com",
                Contrasena = "678213vghavsd",
                Especializacion = "Felinos",
                TarjetaProfesional = "thrta1527",
                FechaNacimiento = new DateTime(1994, 09, 16)

            }; 
            repoVeterinario.AgregarVeterinario(veterinario);
        }

        private static void EditarVeterinario(){
            var veterinario = new Veterinario{
                Id = 3,
                Nombre = "Santiago Ramirez Giraldo",
                Telefono = "301764132213",
                Edad = 12,
                Direccion = "Cra 23 #34-34",
                Correo = "stgr2002@gmail.com",
                Contrasena = "678212313vghavsd",
                Especializacion = "Caninos",
                TarjetaProfesional = "thrta1527",
                FechaNacimiento = new DateTime(2002, 09, 16)

            }; 
            repoVeterinario.EditarVeterinario(veterinario);
        }

        private static void BuscarVeterinario(int idVeterinario){
            var veterinario = repoVeterinario.ObtenerVeterinario(idVeterinario);
            Console.WriteLine("el nombre del veterinario es: " + veterinario.Nombre);
        }

        private static void EliminarVeterinario(int idVeterinario){
            repoVeterinario.EliminarVeterinario(idVeterinario);
        }
    }
}
