namespace HarmonieSanteParamedicalMonolithic.Migrations
{
    using HarmonieSanteParamedicalMonolithic.Bdd;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CHDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CHDBContext context)
        {
            // Ajout de quelques consultants
            var consultants = new List<Consultant>
            {
                new Consultant { Id = 1, FirstName = "John", LastName = "Doe", Speciality = "Dermatologie" },
                new Consultant { Id = 2, FirstName = "Jane", LastName = "Doe", Speciality = "Cardiologie" }
            };
                    consultants.ForEach(c => context.Consultants.AddOrUpdate(p => p.Id, c));

                    // Ajout de quelques patients
                    var patients = new List<Patient>
            {
                new Patient { Id = 1, FirstName = "Alice", LastName = "Smith", Address1 = "2 rue de Rouen", City = "Paris", Postcode = "75003" },
                new Patient { Id = 2, FirstName = "Bob", LastName = "Johnson", Address1 = "18 rue Saint-Maurice", City = "Paris", Postcode = "75005" }
            };
                    patients.ForEach(p => context.Patients.AddOrUpdate(x => x.Id, p));

                    // Ajout de quelques calendriers pour les consultants
                    var consultantCalendars = new List<ConsultantCalendar>
            {
                new ConsultantCalendar { Id = 1, ConsultantId = 1, Date = DateTime.Now.AddDays(1), Available = true },
                new ConsultantCalendar { Id = 2, ConsultantId = 2, Date = DateTime.Now.AddDays(2), Available = false }
            };
                    consultantCalendars.ForEach(c => context.ConsultantCalendars.AddOrUpdate(x => x.Id, c));

                    // Ajout de quelques rendez-vous
                    var appointments = new List<Appointment>
            {
                new Appointment { Id = 1, StartDateTime = DateTime.Now.AddHours(1), EndDateTime = DateTime.Now.AddHours(2), ConsultantId = 1, PatientId = 1 },
                new Appointment { Id = 2, StartDateTime = DateTime.Now.AddHours(3), EndDateTime = DateTime.Now.AddHours(4), ConsultantId = 2, PatientId = 2 }
            };
            appointments.ForEach(a => context.Appointments.AddOrUpdate(x => x.Id, a));

            context.SaveChanges();
        }
    }
}
