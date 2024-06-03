using Microsoft.EntityFrameworkCore;

namespace EjercicioClase3Modulo2EFCore
{
    internal class Program
    {
        static void Main( string[] args )
        {
            #region Pasos previos
            //Ejecutar el script de base de datos en Management Studio para crear la base de datos y la tabla con datos
            //Instalar Microsoft.EntityFrameworkCore y Microsoft.EntityFrameworkCore.SqlServer
            //Crear las entidades necesarias
            //Crear el dbcontext
            //Configurar aqui el connection string e instanciar el contexto de la base de datos.

            var optiones = new DbContextOptionsBuilder<BDContext>();
            optiones.UseSqlServer("Data Source=localhost\\SQL;Initial Catalog=SimpleIMDB;Integrated Security=True;Encrypt=False");

            var context = new BDContext(optiones.Options);

            #endregion

            #region ejercicio 1
            //Obtener un listado de todos los actores y actrices de la tabla actor

            /*var result = context.Actor.ToList();

            foreach (var actor in result)
            {
                Console.WriteLine($"ID: {actor.Id}, Nombre: {actor.Nombre}, Apellido: {actor.Apellido}, Edad: {actor.Edad}, Nombre Artistico: {actor.NombreArtistico}" +
                    $", Nacionalidad: {actor.Nacionalidad}, Genero: {actor.Genero}");
              
            }*/
            #endregion

            #region ejercicio 2
            //Obtener listado de todas las actrices de la tabla actor

            /*var resultActrices = context.Actor.Where(actor => actor.Genero == "F").ToList();
            foreach (var actriz in resultActrices)
            {
                Console.WriteLine($"ID: {actriz.Id}, Nombre: {actriz.Nombre}, Apellido: {actriz.Apellido}, Edad: {actriz.Edad}, Nombre Artistico: {actriz.NombreArtistico}" +
                    $", Nacionalidad: {actriz.Nacionalidad}, Genero: {actriz.Genero}");
            }*/

            #endregion

            #region ejercicio 3
            //Obtener un listado de todos los actores y actrices mayores de 50 años de la tabla actor
            /*var resultActores = context.Actor.Where(actor => actor.Edad > 50).ToList();
            foreach (var actor in resultActores)
            {
                Console.WriteLine($"ID: {actor.Id}, Nombre: {actor.Nombre}, Apellido: {actor.Apellido}, Edad: {actor.Edad}, Nombre Artistico: {actor.NombreArtistico}" +
                     $", Nacionalidad: {actor.Nacionalidad}, Genero: {actor.Genero}");
            }*/
            #endregion

            #region ejercicio 4
            //Obtener la edad de la actriz "Julia Roberts"
            /*var resultJulia = context.Actor.Where(actor => actor.Nombre == "Julia" && actor.Apellido == "Roberts").ToList();
            foreach (var actriz in resultJulia)
            {
                Console.WriteLine($"ID: {actriz.Id}, Nombre: {actriz.Nombre}, Apellido: {actriz.Apellido}, Edad: {actriz.Edad}, Nombre Artistico: {actriz.NombreArtistico}" +
                    $", Nacionalidad: {actriz.Nacionalidad}, Genero: {actriz.Genero}");
            }*/
            #endregion

            #region ejercicio 5
            //Insertar un nuevo actor en la tabla actor con los siguientes datos:
            //nombre: Ricardo
            //apellido: Darin
            //edad: 67 años
            //nombre_artistico: Ricardo Darin
            //nacionalidad: argentino
            //género: Masculino.

            /*Actor newActor = new Actor() { Nombre = "Ricardo", Apellido = "Darin", Edad = 67, NombreArtistico = "Ricardo Darin",
                Nacionalidad = "Argentino", Genero = "M"};

            context.Add(newActor);
            context.SaveChanges();

            Console.WriteLine("SE AGREGO ACTOR CORRECTAMENTE");*/

            //EXTRA - ELIMINAR DATO
            /*var actorDelete = context.Actor.Where(a => a.NombreArtistico == "Ricardo Darin").FirstOrDefault();

            if (actorDelete != null)
            {
                context.Remove(actorDelete);
                context.SaveChanges();
                Console.WriteLine("Actor eliminado correctamente");
            }
            else
            {
                Console.WriteLine("No se encontró el actor a eliminar");
            }*/
            #endregion

            #region ejercicio 6
            //obtener la cantidad de actores y actrices que no son de Estados Unidos.
            /*var resultNoEEUU = context.Actor.Where(actor => actor.Nacionalidad != "USA").Count();

            Console.WriteLine(resultNoEEUU);*/

            #endregion

            #region ejercicio 7
            //obtener los nombres y apellidos de todos los actores maculinos.
            /*var resultActrices = context.Actor.Where(actor => actor.Genero == "M").ToList();
            foreach (var actriz in resultActrices)
            {
                Console.WriteLine($"ID: {actriz.Id}, Nombre: {actriz.Nombre}, Apellido: {actriz.Apellido}");
            }*/
            #endregion
        }
    }
}