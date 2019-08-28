using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLibroDiarioTemplate.Repositories
{
    public class LibroMayorRepository
    {
        private LibroDiarioContext context;
        public LibroMayorRepository(LibroDiarioContext _context)
        {
            context = _context;
        }

        public IList<AsientoLibroMayor> GetAsientoLibroMayor()
        {
            return context.LibroMayor.ToList();
        }

        public Guid CreateAsientoLibroMayor(AsientoLibroMayor asiento)
        {
            asiento.AsientoLibroMayorId = Guid.NewGuid();
            context.LibroMayor.Add(asiento);
            context.SaveChanges();
            return asiento.AsientoLibroMayorId;
        }

        public Guid UpdateAsientoLibroMayor(AsientoLibroMayor asiento)
        {
            context.LibroMayor.Update(asiento);
            context.SaveChanges();
            return asiento.AsientoLibroMayorId;
        }

        public Guid DeleteAsientoLibroMayor(Guid id)
        {
            context.LibroMayor.Delete(asiento);
            context.SaveChanges();
            return asiento.AsientoLibroMayorId;
        }
    }
}
