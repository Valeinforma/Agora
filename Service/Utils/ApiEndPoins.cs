using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Utils
{
    internal class ApiEndPoins
    {
        public static string Capacitacion { get; set; } = "capacitaciones";
        public static string Usuario { get; set; } = "usuarios";
        public static string Inscripcion { get; set; } = "Inscripciones";
        public static string TipoInscripcion { get; set; } = "TipoInscripciones";
        public static string TipoInscripcionCapacitacion { get; set; } = "TiposInscripcionesCapacitaciones";


        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Capacitacion) => Capacitacion,
                nameof(Usuario) => Usuario,
                nameof(Inscripcion) => Inscripcion,
                nameof(TipoInscripcion) => TipoInscripcion,
                nameof(TipoInscripcionCapacitacion) => TipoInscripcionCapacitacion,
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
