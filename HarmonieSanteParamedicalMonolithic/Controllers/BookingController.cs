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
    public class BookingController : Controller
    {
        // GET: Booking
        //TODO: Modifier cette méthode pour afficher le calendrier du praticien. Veiller à ce que l'utilisateur puisse voir en temps réel
        //la disponibilité du practicien;
        public ActionResult GetConsultantCalendar()
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

        //TODO: Modifier cette méthode pour que les utilisateurs ne soient pas obligés d'attendre indéfiniment. 
        public ActionResult ConfirmAppointment(Appointment model)
        {
            CHDBContext dbContext = new CHDBContext();

            //Code pour créer un rendez-vous dans la base de données
            //À réévaluer. Avant de confirmer le rendez-vous, faut-il vérifier si le calendrier du praticien est toujours disponible ?
            Repository repo = new Repository();
            var result = repo.CreateAppointment(model, dbContext);

            return View();
        }
    }
}