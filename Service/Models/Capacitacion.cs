using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Capacitacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
        public DateTime DeleteTime { get; set; }
        public string Ponente { get; set; } = string.Empty;
        public bool InscripcionAbierta { get; set; } = true; // Si la inscripción está abierta o no
        public bool IsDeleted { get; set; } = false; // Presencial, Virtual, Mixta
        public int Cupo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    } 
}
