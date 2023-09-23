namespace HarmonieSanteParamedicalMonolithic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDateTime = c.DateTime(),
                        EndDateTime = c.DateTime(),
                        ConsultantId = c.Int(),
                        PatientId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consultant", t => t.ConsultantId)
                .ForeignKey("dbo.Patient", t => t.PatientId)
                .Index(t => t.ConsultantId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Consultant",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        Speciality = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Address1 = c.String(maxLength: 255),
                        Address2 = c.String(maxLength: 255),
                        City = c.String(maxLength: 50),
                        Postcode = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConsultantCalendar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsultantId = c.Int(),
                        Date = c.DateTime(),
                        Available = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointment", "PatientId", "dbo.Patient");
            DropForeignKey("dbo.Appointment", "ConsultantId", "dbo.Consultant");
            DropIndex("dbo.Appointment", new[] { "PatientId" });
            DropIndex("dbo.Appointment", new[] { "ConsultantId" });
            DropTable("dbo.ConsultantCalendar");
            DropTable("dbo.Patient");
            DropTable("dbo.Consultant");
            DropTable("dbo.Appointment");
        }
    }
}
