using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            TempData["Message"] = "Hello Welcome to in TempData with new Controller";
            ViewBag.color = "";
            return View();
        }
        public IActionResult List()
        {
            Teacher oteacher1 = new Teacher();
            oteacher1.Id = 1;
            oteacher1.Name = "Usman";
            oteacher1.Description = "Welcom to in theta solution";
            oteacher1.Exit = true;

            Teacher oteacher2 = new Teacher();
            oteacher2.Id = 2;
            oteacher2.Name = "Ali";
            oteacher2.Description = "Welcom to in theta solution";
            oteacher2.Exit = true;

            Teacher oteacher3 = new Teacher();
            oteacher3.Id = 3;
            oteacher3.Name = "Mufeez";
            oteacher3.Description = "Welcom to in theta solution";
            oteacher3.Exit = true;
            //IList<Teacher>oteacher= new List<Teacher>();
            //oteacher.Add(oteacher1);
            //oteacher.Add(oteacher2);
            //oteacher.Add(oteacher3);
            //return View(oteacher);
            ViewBag.T1 = oteacher1;
            ViewBag.T2 = oteacher2;
            ViewBag.T3 = oteacher3;
            return View();

        }
        
    }
}
