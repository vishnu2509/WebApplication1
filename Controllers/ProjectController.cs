using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult AddDetailView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDetailView(Project project)
        {
            using (SampleEntities db = new SampleEntities())
            {
                db.Projects.Add(project);
                if (db.SaveChanges() > 0)
                {
                    ViewBag.msg = "Insert Successfully";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.msg = "Not Inserted";
                }
            }

            return View();
        }
    }
}