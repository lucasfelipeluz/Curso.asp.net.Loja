using Loja.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Loja.Services.Exception;

namespace Loja.Services
{
    public class SellerService
    {
        private readonly LojaContext _context;

        public SellerService(LojaContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Sellers
                .Include(obj => obj.Departament)
                .FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if(!_context.Sellers.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found!");
            }

            try
            {
            _context.Update(obj);
            _context.SaveChanges();

            }
            catch (DbConcurrencyException error)
            {
                throw new DbConcurrencyException(error.Message);
            }
        }

    }
}
