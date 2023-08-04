using HarmonieSanteParamedicalMonolithic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarmonieSanteParamedicalMonolithic.Code
{
    public class Repository
    {
    
        public List<Consultant> FetchConsultants(CHDBContext dbContext)
        {
            var cons = dbContext.consultants.ToList();
            return cons;
        }

        public List<ConsultantCalendar> FetchConsultantCalendars(CHDBContext dbContext)
        {
            //Faut-il regrouper les informations relatives au praticien et au calendrier (dates disponibles) ? 
            //Est-ce que c'est pour ça que le calendrier est lent à charger ? Comment est-ce qu'on peut réécrire cela ?

            return dbContext.consultantCalendars.ToList();
        }

        public bool CreateAppointment(Appointment model, CHDBContext dbContext)
        {
            //Est-ce qu'il faut vérifier ici avant de confirmer le rendez-vous ?
            dbContext.appointments.Add(model);
            return true;
        }
    }
}