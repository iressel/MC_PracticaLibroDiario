using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLibroDiarioTemplate.Models.BusinessModel
{
    public class AsientoLibroDiario : AsientoContable
    {
        [Key]
        public Guid AsientoLibroDiarioId { get; set; }
        public DateTime FechaRegistro { get; set; }


        [ForeignKey("Folio")]
        public Guid FolioId { get; set; }
        public AsientoLibroMayor Folio { get; set; }
    }
}
