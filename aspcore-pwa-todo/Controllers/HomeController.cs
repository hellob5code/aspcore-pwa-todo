using Microsoft.AspNetCore.Mvc;

namespace aspcore_pwa_todo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "ASP.Net Core MVC Progressive Web Application TODO Example.";

            return View();
        }    

        public IActionResult Contact()
        {
            ViewBag.Message = "No contact details available.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
