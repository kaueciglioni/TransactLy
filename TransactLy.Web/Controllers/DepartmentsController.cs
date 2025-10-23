using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;
using System.Collections.Generic;
using TransactLy.Web.Models;

namespace TransactLy.Web.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();

            list.Add(new Department { Id = 1, Name = "IT" });
            list.Add(new Department { Id = 2, Name = "Finances" });


            return View(list);
        }
    }
}
