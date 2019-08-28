using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLibroDiarioTemplate.Models
{
    public class AsientoContable
    {
        public decimal Haber { get; set; }
        public decimal Debe { get; set; }
    }
}
