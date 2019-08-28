using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLibroDiarioTemplate.Models.BusinessModel
{
    public class AsientoLibroMayor : AsientoContable
    {
        [Key]
        public Guid AsientoLibroMayorId { get; set; }
        public string NombreCuenta { get; set; }
        public string Folio { get; set; }

        public IEnumerable<AsientoLibroDiario> AsientoLibroDiarios { get; set; }
    }
}
