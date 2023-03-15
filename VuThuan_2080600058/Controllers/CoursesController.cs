using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VuThuan_2080600058.Models;

namespace VuThuan_2080600058.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public CoursesController()
        {
            dbContext = new ApplicationDbContext ()
        }
        // GET: Courses
        public ActionResult Create()
        {
            return View();
        }
    }
}