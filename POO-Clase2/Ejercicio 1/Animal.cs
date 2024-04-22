using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_1
{
    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public virtual void EmitirSonido() { Console.WriteLine("Sonido generico de animal"); }

    }
}
