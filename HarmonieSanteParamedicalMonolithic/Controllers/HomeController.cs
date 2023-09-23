using HarmonieSanteParamedicalMonolithic.Bdd;
using HarmonieSanteParamedicalMonolithic.Models;
using HarmonieSanteParamedicalMonolithic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarmonieSanteParamedicalMonolithic.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ConsultantModelList conList = new ConsultantModelList();
            CHDBContext dbContext = new CHDBContext();
            Repository repo = new Repository();
            List<Consultant> cons = new List<Consultant>();
            cons = repo.FetchConsultants(dbContext);
            conList.ConsultantsList = new SelectList(cons, "Id", "FirstName");
            conList.Consultants = cons;
            return View(conList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "La page de description de votre application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Votre page de contact.";

            return View();
        }
    }
}