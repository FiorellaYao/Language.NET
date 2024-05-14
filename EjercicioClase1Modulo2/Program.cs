using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region JSON
            Console.WriteLine("Ejercicio clase 1 modulo 2");
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);

            // Crear una clase por cada llave del json o pensarlo como una escalera y ver cuantos escalones tiene
            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);

            //Opcion 1: Para descartar mayusculas y minusculas
            //var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            var resultado1 = JsonSerializer.Deserialize<Usuario>(dataEjercicio1);
            var resultado2 = JsonSerializer.Deserialize<Estadistica>(dataEjercicio2);
            var resultado3 = JsonSerializer.Deserialize<Productos>(dataEjercicio3);

            //RESULTADO 1
            Console.WriteLine("\nEjercicio 1");
            Console.WriteLine("Usuario: " + resultado1.Usuario1);
            Console.WriteLine("Amigos: ");
            foreach (var amigo in resultado1.Amigos)
            {
                Console.WriteLine($"- {amigo}");
            }
            Console.WriteLine("Notificaciones activadas: " + resultado1.Notificaciones);

            //RESULTADO 2
            Console.WriteLine("\nEjercicio 2");
            foreach (var equipo in resultado2.Equipos)
            {
                Console.WriteLine($"Equipo: {equipo.Nombre}");
                Console.WriteLine("Jugadores:");
                // Las listas van con [] y se le puede hacer un foreach
                foreach (var jugador in equipo.Jugadores)
                {
                    Console.WriteLine($"- Nombre: {jugador.Nombre}, Kills: {jugador.Kills}, Death: {jugador.Death}");
                }
                Console.WriteLine($"Es campeón: {(equipo.Campeon)}");
            }
            //RESULTADO 3
            Console.WriteLine("\nEjercicio 3");
            foreach (var producto in resultado3.TipoProducto)
            {
                Console.WriteLine($"\nNombre del producto: {producto.Nombre}");
                Console.WriteLine($"Precio: {producto.Precio}");
                Console.WriteLine($"Stock: {producto.Existencias}");
                Console.WriteLine($"Tiene descuento: {producto.Descuento}");
                Console.Write("Etiquetas: ");
                // Las listas van con [] y se le puede hacer un foreach
                foreach (var etiqueta in producto.Etiquetas)
                {
                    Console.Write($"{etiqueta}, ");
                }
                Console.WriteLine($"\nDetalles del producto: ");
                Console.WriteLine($"Peso: {producto.DetallesProd.Peso}");
                Console.WriteLine($"Alto: {producto.DetallesProd.DimensionesProd.Alto}");
                Console.WriteLine($"Ancho: {producto.DetallesProd.DimensionesProd.Ancho}");
                Console.WriteLine($"Profundidad: {producto.DetallesProd.DimensionesProd.Profundidad}");
            }


            #endregion
        }
    }
}