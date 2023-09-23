using HarmonieSanteParamedicalMonolithic.Bdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarmonieSanteParamedicalMonolithic.Models
{
    public class ConsultantModel
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Speciality { get; set; }
    }

    public class ConsultantModelList
    {
        public List<ConsultantCalendar> ConsultantCalendars { get; set; }
        public List<Consultant> Consultants { get; set; }
        public int SelectedConsultantId { get; set; }
        public SelectList ConsultantsList { get; set; }
    }

}