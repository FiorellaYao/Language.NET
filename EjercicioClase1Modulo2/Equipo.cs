using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    public class Equipo
    {
        [JsonPropertyName("equipo")]
        public string? Nombre { get; set; }

        [JsonPropertyName("jugadores")]
        public List<Jugador>? Jugadores { get; set; }

        [JsonPropertyName("campeon")]
        public bool? Campeon { get; set; }
    }
}
