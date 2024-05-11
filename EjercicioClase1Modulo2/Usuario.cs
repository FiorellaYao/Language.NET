using System.Text.Json.Serialization;
using static EjercicioClase1Modulo2.Program;

namespace EjercicioClase1Modulo2
{
    public class Usuario
    {
        //Para descartar mayusculas y minusculas : JsonPropertyName
        [JsonPropertyName("usuario")] //Data - Como viene originalmente
        public string? Usuario1 { get; set; }

        [JsonPropertyName("amigos_usuario")] //Data 
        public List<string>? Amigos { get; set; }

        [JsonPropertyName("notificaciones_usuario")] //Data 
        public bool Notificaciones { get; set; }
    }
}
