using PracticaLibroDiarioTemplate.Models.BusinessModel;
using PracticaLibroDiarioTemplate.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLibroDiarioTemplate.Repositories
{
    public class LibroDiarioRepository
    {
        private LibroDiarioContext context;
        public LibroDiarioRepository(LibroDiarioContext _context)
        {
            context = _context;
        }

        public IList<AsientoLibroDiario> GetAsientoLibroDiario()
        {
            return context.LibroDiario.ToList();
        }

        public Guid CreateAsientoLibroDiario(AsientoLibroDiario asiento)
        {
            asiento.AsientoLibroDiarioId = Guid.NewGuid();
            context.LibroDiario.Add(asiento);
            context.SaveChanges();
            return asiento.AsientoLibroDiarioId;
        }

        public Guid UpdateAsientoLibroDiario(AsientoLibroDiario asiento)
        {
            context.LibroDiario.Update(asiento);
            context.SaveChanges();
            return asiento.AsientoLibroDiarioId;
        }

        public Guid DeleteAsientoLibroDiario(Guid id)
        {
            var asiento = context.LibroDiario.Find(id);
            context.LibroDiario.Remove(asiento);
            context.SaveChanges();
            return asiento.AsientoLibroDiarioId;
        }
    }
}
