using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_1
{
    public class Perro : Animal
    {
        public string? SegundoAnimal { get; set; }

        //CAMBIA EL SONIDO ORIGINAL, HEREDADO POR PADRE "ANIMAL.CS"
        public override string EmitirSonido()
        {
            return "¡Guau!";
        }
    }
}
