using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SalesWebMVC.Models
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departmentslist = new List<Department>();
            departmentslist.Add(new Department { Id = 1, Name = "William" });
            departmentslist.Add(new Department { Id = 2, Name = "Gabriel" });

            return View(departmentslist);
        }
    }
}
