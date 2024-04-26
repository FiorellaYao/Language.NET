using Clase3.Ejercicio_1;
using Clase3.Ejercicio_2;

namespace Clase3
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo
            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            //ImprimirDatosVehiculo(moto);
            //ImprimirDatosVehiculo(auto);
            void ImprimirDatosVehiculo(Vehiculo vehiculo)
            {
                vehiculo.ImprimirDatosVehiculo();
            }

            Moto moto1 = new("Honda", "ABC123", 500, "Rojo");
            Moto moto2 = new("Suzuki", "WYZ 987", 120, "Azul"); 
            ImprimirDatosVehiculo(moto1);
            ImprimirDatosVehiculo(moto2);

            Auto auto1 = new("Renault", "Jeep", true);
            Auto auto2 = new("Ford", "Cooper", false);
            ImprimirDatosVehiculo(auto1);
            ImprimirDatosVehiculo(auto2);

            Console.ReadKey();
            #endregion


            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca
            Biblioteca biblioteca = new Biblioteca();

            List<string> todosLosLibros = biblioteca.ObtenerTodosLosLibros();

            Console.WriteLine($"\nTodos los libros disponibles: ");
            //"forEach" recorre cada elemento de la lista 'todosLosLibros' y muestre uno por uno
            todosLosLibros.ForEach(libro => Console.WriteLine(libro));

            Console.ReadKey();
            #endregion
        }
    }
}