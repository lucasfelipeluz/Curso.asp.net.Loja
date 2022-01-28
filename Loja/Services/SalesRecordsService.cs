using Loja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Loja.Services
{
    public class SalesRecordsService
    {
        private readonly LojaContext _context;

        public SalesRecordsService(LojaContext context)
        {
            _context = context;
        }
        public List<SalesRecords> FindByDate(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecords select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.Date)
                .ToList();
        }
    }
}
