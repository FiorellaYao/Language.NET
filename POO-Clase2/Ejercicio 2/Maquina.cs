using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_2
{
    public abstract class Maquina
    {
        public string Marca { get; set; }
        
        public void Encender() { Console.WriteLine("Se encendio la maquina!"); }
        public void Apagar() { Console.WriteLine("Se apago la maquina!"); }


    }
}
