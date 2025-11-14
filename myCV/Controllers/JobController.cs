using Microsoft.AspNetCore.Mvc;
using myCV.Models;

namespace myCV.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            ViewData["JobList"] = HomeController.jobs;
            return View();
        }
    }
}
