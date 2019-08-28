using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLibroDiarioTemplate.Models.BusinessModel
{
    public abstract class AsientoContable
    {
        /// <summary>
        /// Es lo que sucede con nuestro asiento contable, la operacion
        /// </summary>
        public string Detalle { get; set; }
        /// <summary>
        /// El monto de debe. Es Dinero
        /// </summary>
        public decimal Debe { get; set; }
        /// <summary>
        /// El monto de haber. Es dinero
        /// </summary>
        public decimal Haber { get; set; }

        // TODO: Moneda, el ya sea pesos, soles, bolivares, dolares ,yen . El metadato. 
    }
}
