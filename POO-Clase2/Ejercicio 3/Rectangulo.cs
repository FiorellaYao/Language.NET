using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Rectangulo : FiguraGeometrica
    {
        //Propiedades: Base y Altura
        public int Base { get; set; }
        public int Altura { get; set; }

        public override int CalcularArea()
        {
            return Base * Altura;
        }

        public override int CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
