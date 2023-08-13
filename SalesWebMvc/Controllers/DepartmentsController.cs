using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> nList = new List<Department>();

            nList.Add(new Department { Id = 1, Name = "Eletronicos", });
            nList.Add(new Department { Id = 2, Name = "Moda" });
            nList.Add(new Department { Id = 3, Name = "Cozinha" });



            return View(nList);
        }
    }
}
