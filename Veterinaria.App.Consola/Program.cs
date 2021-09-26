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
        private static IRepositorioPlanVacunacion repoPlanVacunacion = new RepositorioPlanVacunacion(new Persistencia.AppContext());
        private static IRepositorioHistoriaClinica repoHistoriaClinica = new RepositorioHistoriaClinica(new Persistencia.AppContext());
        private static IRepositorioAdministrador repoAdministrador = new RepositorioAdministrador(new Persistencia.AppContext());
        private static IRepositorioCita repoCita = new RepositorioCita(new Persistencia.AppContext());
        private static IRepositorioDueno repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        static void Main(string[] args)
        {  
            //AgregarDueno();
            //BuscarDueno(1);
            //EditarDueno();
            //EliminarDueno(2); 

            //AgregarCita();
            //BuscarCita(1);
            //EditarCita();
            //EliminarCita(2);

            //AgregarPlanVacunacion();
            //BuscarPlanVacunacion(1);
            //EditarPlanVacunacion();
            //EliminarPlanVacunacion(2);

            //AgregarHistoriaClinica();
            //BuscarHistoriaClinica(1);
            //EditarHistoriaClinica();
            //EliminarHistoriaClinica(2);

            //AgregarAdministrador();
            //BuscarAdministrador(1);
            //EditarAdministrador();
            //EliminarAdministrador(1);
           
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


        private static void AgregarDueno(){
            var dueno = new Dueno{
                Nombre = "Alex Morales",
                Telefono = "3103216156",
                Edad = 42,
                Direccion = "Cra 7 #23-20",
                Correo = "casanare@gmail.com",
                Contrasena = "LaM1sm4",
            }; 
            repoDueno.AgregarDueno(dueno);
        }

        private static void EditarDuenor(){
            var dueno = new Dueno{
                Id = 1,
                Nombre = "Rafael Morales",
                Telefono = "3103216156",
                Edad = 42,
                Direccion = "Calle 17 #23-20",
                Correo = "casanare@gmail.com",
                Contrasena = "LaM1sm4",
            }; 
            repoDueno.EditarDueno(dueno);
        }

        private static void BuscarDueno(int idDueno){
            var dueno = repoDueno.ObtenerDueno(idDueno);
            Console.WriteLine("el nombre del Dueño es: " + dueno.Nombre);
        }

        private static void EliminarDueno(int idDueno){
            repoDueno.EliminarDueno(idDueno);
        }

        private static void AgregarCita(){
            var cita = new Cita{
                FechaCita = new DateTime(2021, 09, 24),
                TipoConsulta = "Ambulatoria",
                MotivoConsulta = "La mascota presenta fuertes dolores abdominales",
                IdDueno = 1,
                IdVeterinario = 5
            };
            repoCita.AgregarCita(cita);
        }

        private static void BuscarCita(int idCita){
            var cita = repoCita.ObtenerCita(idCita);
            Console.WriteLine("el motivo de consulta de la cita es: " + cita.MotivoConsulta);
        }

         private static void EditarCita(){
            var cita = new Cita{
                Id = 1,
                FechaCita = new DateTime(2021, 10, 24),
                TipoConsulta = "De Urgencia",
                MotivoConsulta = "La mascota presenta fuertes dolores abdominales, y en la parte superior del cuello",
                IdDueno = 1,
                IdVeterinario = 8
            };

            repoCita.EditarCita(cita);
        }

        private static void EliminarCita(int idCita){
            repoCita.EliminarCita(idCita);
        } 

        private static void AgregarPlanVacunacion(){
            var planvacunacion = new PlanVacunacion{
                Nombre = "Brigada 2021 papiloma",
                Descripcion = "Jornada de vacunación masiva del papiloma humano"
            };
            repoPlanVacunacion.AgregarPlanVacunacion(planvacunacion);
        }

        private static void BuscarPlanVacunacion(int idPlanVacunacion){
            var planvacunacion = repoPlanVacunacion.ObtenerPlanVacunacion(idPlanVacunacion);
            Console.WriteLine("el nombre del plan de vacunación es: " + planvacunacion.Nombre);
        }

        private static void EditarPlanVacunacion(){
            var planvacunacion = new PlanVacunacion{
                Id = 1,
                Nombre = "Brigada 2021 Papiloma Humano",
                Descripcion = "Jornada de vacunación COMUNITARIA del papiloma humano"
            };

            repoPlanVacunacion.EditarPlanVacunacion(planvacunacion);
        }

        private static void EliminarPlanVacunacion(int idPlanVacunacion){
            repoPlanVacunacion.EliminarPlanVacunacion(idPlanVacunacion);
        } 

        private static void AgregarHistoriaClinica(){
            var historiaclinica = new HistoriaClinica{
                ContenidoHistoriaClinica = "bla bla bla bla bla bla bla bla bla bla bla bla",
                FechaHistoriaClinica = new DateTime(2021, 02, 02),
                IdAnimal = 1,
                IdDiagnostico = 1
            };
            repoHistoriaClinica.AgregarHistoriaClinica(historiaclinica);
        }

        private static void BuscarHistoriaClinica(int idHistoriaClinica){
            var historiaclinica = repoHistoriaClinica.ObtenerHistoriaClinica(idHistoriaClinica);
            Console.WriteLine("el contenido de la Historia Clinica es: " + historiaclinica.ContenidoHistoriaClinica);
        }

        private static void EditarHistoriaClinica(){
            var historiaclinica = new HistoriaClinica{
                Id = 1,
                ContenidoHistoriaClinica = "Paula se fue y le dolio la cabeza",
                FechaHistoriaClinica = new DateTime(2021, 03, 03),
                IdAnimal = 1,
                IdDiagnostico = 1
            };

            repoHistoriaClinica.EditarHistoriaClinica(historiaclinica);
        }

        private static void EliminarHistoriaClinica(int idHistoriaClinica){
            repoHistoriaClinica.EliminarHistoriaClinica(idHistoriaClinica);
        } 

        private static void AgregarAdministrador(){
            var administrador = new Administrador{
                Nombre = "Alex Morales",
                Telefono = "3103216156",
                Edad = 42,
                Direccion = "Cra 7 #23-20",
                Correo = "casanare@gmail.com",
                Contrasena = "LaM1sm4",
            }; 
            repoAdministrador.AgregarAdministrador(administrador);
        }

        private static void EditarAdministrador(){
            var administrador = new Administrador{
                Id = 1,
                Nombre = "Rafael Morales",
                Telefono = "3103216156",
                Edad = 42,
                Direccion = "Calle 17 #23-20",
                Correo = "casanare@gmail.com",
                Contrasena = "LaM1sm4",
            }; 
            repoAdministrador.EditarAdministrador(administrador);
        }

        private static void BuscarAdministrador(int idAdministrador){
            var administrador = repoAdministrador.ObtenerAdministrador(idAdministrador);
            Console.WriteLine("el nombre del Administrador es: " + administrador.Nombre);
        }

        private static void EliminarAdministrador(int idAdministrador){
            repoAdministrador.EliminarAdministrador(idAdministrador);
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
