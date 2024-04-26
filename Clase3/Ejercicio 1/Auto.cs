using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_1
{
    public class Auto : Vehiculo
    {
        public bool Usado { get; set; }

        // Constructor para inicializar las propiedades específicas del auto
        public Auto(string marca, string modelo, bool usado) : base(marca, modelo)
        {
            Usado = usado;
        }
        public override void ImprimirDatosVehiculo()
        {
            base.ImprimirDatosVehiculo();
            Console.WriteLine($"\nDETALLES DEL AUTO= Marca: {Marca}, Modelo: {Modelo}, Usado: {Usado}");
        }
    }
}
