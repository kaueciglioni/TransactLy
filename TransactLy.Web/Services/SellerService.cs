using TransactLy.Web.Data;
using TransactLy.Web.Models;

namespace TransactLy.Web.Services
{
    public class SellerService
    {
        private readonly TransactLyContext _context;

        public SellerService(TransactLyContext context)
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
