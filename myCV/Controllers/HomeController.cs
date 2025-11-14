using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myCV.Models;

namespace myCV.Controllers
{
    public class HomeController : Controller
    {
        //input data:
        public static IList<Job> jobs = new List<Job>
        {
            new Job("Python Engineer", "in¿ynier Python", "Worked on X", "opis...1", new DateOnly(2017, 3, 1), new DateOnly(2019, 2, 28), "Company A"),
            new Job("SQL Developer", "deweloper SQL","Worked on Y", "opis...2", new DateOnly(2019, 3, 1), new DateOnly(2025, 10, 31), "Company B")
        };
        
        public static IList<Education> educations = new List<Education>
        {
            new Education("University X", "Uniwersytet X", "Bachelor of Science in Computer Science", "Licencjat z informatyki", new DateOnly(2013, 9, 1), new DateOnly(2017, 6, 30), "Description............1", "Opis............1"),
            new Education("University Y", "Uniwersytet Y", "Master of Science in Software Engineering", "Magister in¿ynierii oprogramowania", new DateOnly(2017, 9, 1), new DateOnly(2019, 6, 30), "Description............2", "Opis............2")
        };



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["JobList"] = jobs;
            ViewData["EducationList"] = educations;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
