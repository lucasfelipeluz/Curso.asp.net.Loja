using System;

using Loja.Models;
using Loja.Models.Enums;
using System.Linq;

namespace Loja.Data
{
    public class SeedingService
    {
        private LojaContext _context;

        public SeedingService(LojaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() || _context.Sellers.Any() || _context.Sellers.Any())
            {
                return; //DB já foi populado.
            }

            Departament d1 = new Departament(1, "Computers");
            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            SalesRecords r1 = new SalesRecords(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);

            _context.Departament.AddRange(d1);
            _context.Sellers.AddRange(s1);
            _context.SalesRecords.AddRange(r1);
            _context.SaveChanges();
        }
    }
}
