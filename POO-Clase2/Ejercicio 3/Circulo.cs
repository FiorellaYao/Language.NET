using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Circulo : FiguraGeometrica
    {
        //Propiedades: Radio
        public int Radio { get; set; }
        public override int CalcularArea()
        {
            return (int)(Math.PI * Radio * Radio);
        }

        public override int CalcularPerimetro()
        {
            return (int)(2 * Math.PI * Radio);
        }
    }
}
