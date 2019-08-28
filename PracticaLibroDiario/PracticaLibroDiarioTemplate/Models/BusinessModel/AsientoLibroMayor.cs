using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLibroDiarioTemplate.Models.BusinessModel
{
    public class AsientoLibroMayor : AsientoContable
    {
        public Guid AsientoLibroMayorId { get; set; }
        public string NombreCuenta { get; set; }
        public string Folio { get; set; }

        public IEnumerable<AsientoLibroDiario> AsientoLibroDiarios { get; set; }
    }
}
