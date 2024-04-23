using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_2
{
    public abstract class Maquina
    {
        public string? Marca { get; set; }
        public int Precio { get; set; }

        public virtual string Encender() { return "Encendida"; }
        public virtual string Apagar() { return "Apagada"; }


    }
}
