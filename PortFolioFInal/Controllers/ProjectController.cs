using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PortFolioFInal.Data;
using PortFolioFInal.Models;

namespace PortFolioFInal.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProjectController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            List<Project> objProjectList = _db.Projects.ToList();
            return View(objProjectList);
        }

      
        [HttpPost]
        public IActionResult UpdateList(List<Project> projects)
        {

            var allProjects = _db.Projects.ToList();
            _db.Projects.RemoveRange(allProjects);
            _db.SaveChanges();
            foreach (var project in projects)
            {
                var existingProject = _db.Projects.Find(project.id);

                _db.Projects.Add(project);              

                _db.SaveChanges();
            }


            // Redirect or return a response as needed
            return RedirectToAction("Index");
        }

    }
}
