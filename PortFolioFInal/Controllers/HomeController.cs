using PortFolioFInal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PortFolioFInal.Data;

namespace PortFolioFInal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration _config;

        public HomeController(ApplicationDbContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }


        public IActionResult _Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult Index()
        {
            // Retrieve projects from the database
            var projects = _db.Projects.ToList();

            // Retrieve skills from the database
            var skills = _db.Skills.ToList();

            // Create the view model
            var viewModel = new Home
            {
                Projects = projects,
                Skills = skills
            };

            // Pass the view model to the view
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult SubmitContactForm(ContactModel contactForm)
        {
            if (ModelState.IsValid)
            {
                // Process the form data, save to the database, etc.

                // Redirect to a success page or another action
                

            }
            _db.ContactModels.Add(contactForm);
            _db.SaveChanges();

            // If the model is not valid, return to the contact form with errors
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult LoginFun(Home model)
        {
            var adminUsername = _config["Admin:Username"];
            var adminPassword = _config["Admin:Password"];

            // Admin credentials come from configuration (user-secrets / environment
            // variables). If they are not configured, no login can succeed.
            if (!string.IsNullOrEmpty(adminUsername) && !string.IsNullOrEmpty(adminPassword)
                && model.LoginModel.Username == adminUsername
                && model.LoginModel.Password == adminPassword)
            {
                return RedirectToAction("Aft");
            }

            return RedirectToAction("Index");
        }
        public IActionResult Aft()
        {
            return View();
        }
        public IActionResult Bef()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            var feedbackData = _db.ContactModels.ToList(); // Assuming _db is your ApplicationDbContext

            return View(feedbackData);
        }
    }
}

