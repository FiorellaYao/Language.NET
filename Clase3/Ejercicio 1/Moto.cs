using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_1
{
    public class Moto : Vehiculo
    {
        public int Velocidad { get; set; }
        public string Color { get; set; }

        // Constructor para inicializar las propiedades específicas de la moto
        public Moto(string marca, string modelo, int velocidad, string color) : base(marca, modelo)
        {
            Velocidad = velocidad;
            Color = color;
        }
        public override void ImprimirDatosVehiculo()
        {
            base.ImprimirDatosVehiculo();
            Console.WriteLine($"\nDETALLES DE LA MOTO= Marca: {Marca}, Modelo: {Modelo}, Velocidad: {Velocidad}, Color: {Color}");
        }
    }
}
