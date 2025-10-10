using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public TipoInscripcion? TipoInscripcion { get; set; }
        public int TipoInscripcionId { get; set; }
        public Capacitacion? Capacitacion { get; set; }
        public int CapacitacionId { get; set; }
        public bool Acreditado { get; set; } = false; // Indica si la inscripción ha sido acreditada
        public decimal Importe { get; set; } = 0;
        public bool Pagado { get; set; }
        public int? UsuarioCobroId { get; set; }
        public Usuario? UsuarioCobro { get; set; }
        public bool IsDeleted { get; set; } = false; // Indica si la inscripción está eliminada

        public override string ToString()
        {
            return $"{Usuario?.Apellido}, {Usuario?.Nombre}, {TipoInscripcion?.Nombre}";
        }

    }
}
