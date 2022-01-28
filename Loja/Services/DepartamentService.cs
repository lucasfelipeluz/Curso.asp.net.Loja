using Loja.Models;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Services
{
    public class DepartamentService
    {
        private readonly LojaContext _context;

        public DepartamentService(LojaContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }

    }
}
