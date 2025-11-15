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
            new Job("Software Developer", "Programista", 
                "My own company", 
                "Tworzenie oprogramowania na zlecenie podmiotów", 
                new DateOnly(2024, 7, 1), new DateOnly(), "FlexCode"),
            new Job("Backend Developer", "Programista",
                "Development and optimization of software solutions, including ERP and WMS systems\nIntegration of client systems with third-party software solutions\nCreation and maintenance of technical documentation for developed IT solutions\nCollaboration with business analysts to estimate, plan and implement IT solutions",
                "Tworzenie i rozwój oprogramowania - systemy: ERP, WMS\nIntegrowanie systemów klienta z oprogramowaniem ich kontrahentów\nDokumentowanie opracowanych rozwiązań informatycznych\nWspółdziałanie z analitykami biznesowymi w procesie estymacji rozwiązań informatycznych", 
                new DateOnly(2021, 3, 1), new DateOnly(2024,6,30), "Euvic"),
            new Job("Database Developer", "Programista baz danych",
                "Development and enhancement of software solutions, focusing on WMS systems\nCreation of technical and database-related documentation\nPreparation of functional analysis for database-driven solutions\nImplementation and testing of database solutions and integrations",
                "Tworzenie i rozwój oprogramowania - system typu WMS\nTworzenie dokumentacji\nPrzygotowywanie analizy funkcjonalnej\nWdrażanie i testowanie oprogramowania", 
                new DateOnly(2019, 3, 1), new DateOnly(2021, 2, 28), "Mecalux"),
            new Job("Software Technician", "Serwisant oprogramowania",
                "Troubleshooting issues reported by users during the use of applications\nImplementation of medical software solutions\nUpdating and optimizing application, database and system software\nConducting user training and providing on-site support for clients\nConsulting on system development and expansion of client's IT resources",
                "Rozwiązywanie problemów powstałych przez użytkowników podczas korzystania z aplikacji\nWdrażanie oprogramowania medycznego\nAktualizowanie i optymalizowanie oprogramowania aplikacyjnego, bazodanowego i systemowego\nSzkolenia użytkowników, wizyty serwisowe u klientów\nDoradztwo w zakresie rozwoju systemu oraz rozbudowy zasobów informatycznych﻿", 
                new DateOnly(2017, 9, 1), new DateOnly(2019, 2, 28), "Info-Lider")
        };
        
        public static IList<Education> educations = new List<Education>
        {
            new Education("Institute of Information Technologies (WSTI) in Katowice", "Wyższa Szkoła Technologii Informatycznych w Katowicach", "Bachelor of Engineering in Computer Science", "Inżynier informatyki", new DateOnly(2017, 10, 1), new DateOnly(2021, 6, 30), "Specjalization: software engineering", "Specjalizacja: inżynieria oprogramowania", "https://www.wsti.pl"),
            new Education("University of Economics in Katowicach", "Uniwersytet Ekonomiczny w Katowicach", "Master of Economics", "Magister ekonomii", new DateOnly(2014, 10, 1), new DateOnly(2016, 6, 30), "Specjalization: electronic economy", "Specjalizacja: gospodarka elektroniczna", "https://www.ue.katowice.pl"),
            new Education("University of Economics in Katowicach", "Uniwersytet Ekonomiczny w Katowicach", "Bachelor of International Economic Relations", "Licencjat międzynarodowych stosunków gospodarczych", new DateOnly(2011, 10, 1), new DateOnly(2014, 6, 30), "Specjalization: international business", "Specjalizacja: biznes międzynarodowy", "https://www.ue.katowice.pl")
        };

        public static IList<Hobby> hobbies = new List<Hobby>
        {
            new Hobby("Swiming", "Pływanie", "I have been swiming since I was 6 years old", "pływam od 6'tego roku życia"),
            new Hobby("Climbing", "Wspinaczka", "this is a great opportunity to overcome your weaknesses", "ten sport daje okazje do pokonywania swoich słabości"),
            new Hobby("Squash", "Squash", "one of the few sports which I enjoy running", "jeden z nielicznych sportów, gdzie chętnie biegam"),
            new Hobby("Dog training", "Tresura psa", "I love spending time with my dog (Coco)", "uwielbiam spędzać czas ze swoim psiakiem (Coco)"),
            new Hobby("Board games", "Gry planszowe", "together with friends, mainly strategy games", "razem ze znajomymi, głównie gry strategiczne"),
            new Hobby("Computer games", "Gry komputerowe", "mainly strategy and RPG games", "głównie gry strategiczne i RPG")
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
            ViewData["HobbyList"] = hobbies;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
