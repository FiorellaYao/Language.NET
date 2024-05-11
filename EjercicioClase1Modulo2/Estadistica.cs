using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    public class Estadistica
    {
        [JsonPropertyName("estadistica")]
        public List<Equipo> Equipos { get; set; }
    }
}
