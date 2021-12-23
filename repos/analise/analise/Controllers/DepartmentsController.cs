using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using analise.Models;

namespace analise.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = new List<Department>();
            List.Add(new Department { id = 1, Name = "Exames" });
            List.Add(new Department { id = 2, Name = "Farmacias" });
            List.Add(new Department { id = 3, Name = "Vacinas" });
            return View(List);
        }
    }
}
