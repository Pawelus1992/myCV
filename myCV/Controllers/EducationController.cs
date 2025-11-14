using Microsoft.AspNetCore.Mvc;
using myCV.Models;

namespace myCV.Controllers
{
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            ViewData["EducationList"] = HomeController.educations;
            return View();
        }
    }
}
