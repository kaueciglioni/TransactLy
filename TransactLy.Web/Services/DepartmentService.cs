using TransactLy.Web.Data;
using TransactLy.Web.Models;

namespace TransactLy.Web.Services
{
    public class DepartmentService
    {
        private readonly TransactLyContext _context;

        public DepartmentService(TransactLyContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
