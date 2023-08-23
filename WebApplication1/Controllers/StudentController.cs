using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Hello = "Home Task Multiple controller with viwes (Used ViewBag)(ViewData)(TempData)";
            ViewBag.Condition = "2";
            return View();
        }
        [ViewData]
        public string? Title { get; set; }
        public IActionResult Home()
        {
            Title = "Home Page";
            return View();
        }
    }
}
