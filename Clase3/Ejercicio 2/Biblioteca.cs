using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_2
{
    public class Biblioteca : IBiblioteca
    {
        public List<string> Libros { get; set; }

        public Biblioteca()
        {
            Libros = new List<string>()
            {
                "Cien años de soledad",
                "1984",
                "Don Quijote de la Mancha",
                "Matar a un ruiseñor",
                "El Gran Gatsby",
                "Orgullo y prejuicio",
                "Crónica de una muerte anunciada",
                "El señor de los anillos",
                "Los miserables",
                "La sombra del viento"
            };
        }
        public List<string> ObtenerTodosLosLibros()
        {   
            return Libros;
        }
        

    }
}
