using PracticaLibroDiarioTemplate.Models.BusinessModel;
using PracticaLibroDiarioTemplate.Models.Contexts;
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
            var asiento = context.LibroMayor.Find(id);
            context.LibroMayor.Remove(asiento);
            context.SaveChanges();
            return asiento.AsientoLibroMayorId;
        }
    }
}
