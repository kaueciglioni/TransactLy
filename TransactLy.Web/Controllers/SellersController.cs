using Microsoft.AspNetCore.Mvc;

namespace TransactLy.Web.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
