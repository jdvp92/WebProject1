using WebProject1.Data;
using System.Collections.Generic;
using System.Linq;
using WebProject1.Models;

namespace WebProject1.Services
{
    public class SellerService
    {

        private readonly WebProject1Context _context;

        public SellerService(WebProject1Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

       public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
