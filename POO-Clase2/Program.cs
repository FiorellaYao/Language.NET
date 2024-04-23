using POO_Clase2.Ejercicio_1;
using POO_Clase2.Ejercicio_2;
using POO_Clase2.Ejercicio_3;

namespace POO_Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            // Configurar el metodo Emitir sonido para que cada tipo de animal haga un sonido diferente
            // el metodo emitir sonido no devuelve nada (void), imprimir en consola el "sonido"

            Perro perro1 = new() { 
                //Propiedades: Edad, Nombre, Especie
                Edad = 2,
                Nombre = "Marley",
                Especie = "Canino"
            };

            Gato gato1 = new() {
                Edad = 5, 
                Nombre = "Blanca", 
                Especie = "Felino"
            };

            Console.WriteLine($"Me llamo {gato1.Nombre}, soy un {gato1.Especie} y hago {gato1.EmitirSonido()}");
            Console.WriteLine($"Me llamo {perro1.Nombre}, soy un {perro1.Especie} y hago {perro1.EmitirSonido()}");
            #endregion

            #region Ejercicio 2 
            // Agregar la propiedad "Peso" unicamente para las notebooks 
            // Agregar la propiedad "Refactorizada" que debe ser un booleano unicamente para las PcEscritorio
            // Instanciar una notebook y una pcEscritorio
            // Imprimir por pantalla las propiedades de cada uno

            Notebook notebook = new Notebook()
            {
                Marca = "Notebook XYZ",
                Precio = 1000,
                Peso = 2 // Propiedad específica de Notebook
            };

            PcEscritorio pcEscritorio = new PcEscritorio()
            {
                Marca = "PcEscritorio ABC",
                Precio = 800,
                Refactorizada = false // Propiedad específica de PcEscritorio
            };

            Console.WriteLine($"La maquina notebook esta: {notebook.Encender()}");
            Console.WriteLine("Propiedades de la Notebook:");
            Console.WriteLine($"Modelo: {notebook.Marca}");
            Console.WriteLine($"Precio: ${notebook.Precio}");
            Console.WriteLine($"Peso: {notebook.Peso} kg");
            Console.WriteLine($"La maquina notebook esta: {notebook.Apagar()}");

            Console.WriteLine($"\nLa maquina PcEscritorio esta: {pcEscritorio.Encender()}");
            Console.WriteLine("Propiedades de la PcEscritorio:");
            Console.WriteLine($"Modelo: {pcEscritorio.Marca}");
            Console.WriteLine($"Precio: ${pcEscritorio.Precio}");
            if (pcEscritorio.Refactorizada)
            {
                Console.WriteLine($"Refactorizada: La propiedad es verdadera");
            }
            else
            {
                Console.WriteLine($"Refactorizada: La propiedad es falsa");
            }
            Console.WriteLine($"La maquina PcEscritorio esta: {pcEscritorio.Apagar()}");

            Console.ReadLine();

            #endregion

            #region Ejercicio 3

            // Crear la clase "FiguraGeometrica" la cual debe ser abstracta y tener 2 metodos, uno para calcular el area y el otro el perimetro
            // Crear dos clases "Circulo" y "Rectangulo" que deben heredar de "FiguraGeometrica"
            // Implementar los metodos para que cada figura calcule el area y el perimetro como corresponda
            // Instanciar las clases e imprimir los valores del area y el perimetro para cada figura
            // Mostrar los resultados por consola

            Circulo circulo = new() { Radio = 5 };

            // Instanciar un rectángulo
            Rectangulo rectangulo = new () { Base = 4, Altura = 3 };

            // Imprimir los resultados para el círculo
            Console.WriteLine("Círculo:");
            Console.WriteLine($"Área: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");

            // Imprimir los resultados para el rectángulo
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");

            Console.ReadLine();

            #endregion
        }
    }
}