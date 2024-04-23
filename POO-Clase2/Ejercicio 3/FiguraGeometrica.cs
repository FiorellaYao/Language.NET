using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    //Clase abstracta FiguraGeometrica
    public abstract class FiguraGeometrica
    {
       // Método abstracto para calcular el área
       public abstract int CalcularArea();

       // Método abstracto para calcular el perímetro
       public abstract int CalcularPerimetro();
    }
}
