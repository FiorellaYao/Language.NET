using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    public class Producto
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("precio")]
        public double Precio { get; set; }

        [JsonPropertyName("existencias")]
        public int Existencias { get; set; }

        [JsonPropertyName("descuento_disponible")]
        public bool Descuento { get; set; }

        [JsonPropertyName("etiquetas")]
        public List<string>? Etiquetas { get; set; }

        [JsonPropertyName("detalles")]
        public Detalles? DetallesProd { get; set; }
    }
}
