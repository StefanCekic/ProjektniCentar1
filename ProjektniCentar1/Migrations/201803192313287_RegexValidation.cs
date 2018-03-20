namespace ProjektniCentar1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegexValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KontaktOsoba", "Ime", c => c.String(nullable: false));
            AlterColumn("dbo.KontaktOsoba", "Prezime", c => c.String(nullable: false));
            AlterColumn("dbo.KontaktOsoba", "RadnoMesto", c => c.String(nullable: false));
            AlterColumn("dbo.Preduzece", "NazivPreduzeca", c => c.String(nullable: false));
            AlterColumn("dbo.Preduzece", "AdresaPreduzeca", c => c.String(nullable: false));
            AlterColumn("dbo.Preduzece", "Opstina", c => c.String(nullable: false));
            AlterColumn("dbo.Preduzece", "PostanskiBroj", c => c.String(nullable: false));
            AlterColumn("dbo.Preduzece", "MaticniBroj", c => c.String(nullable: false));
            AlterColumn("dbo.Preduzece", "PIB", c => c.String(nullable: false));
            AlterColumn("dbo.Preduzece", "BrojRacuna", c => c.String(nullable: false));
            AlterColumn("dbo.Preduzece", "WebStranica", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Preduzece", "WebStranica", c => c.String());
            AlterColumn("dbo.Preduzece", "BrojRacuna", c => c.String());
            AlterColumn("dbo.Preduzece", "PIB", c => c.String());
            AlterColumn("dbo.Preduzece", "MaticniBroj", c => c.String());
            AlterColumn("dbo.Preduzece", "PostanskiBroj", c => c.String());
            AlterColumn("dbo.Preduzece", "Opstina", c => c.String());
            AlterColumn("dbo.Preduzece", "AdresaPreduzeca", c => c.String());
            AlterColumn("dbo.Preduzece", "NazivPreduzeca", c => c.String());
            AlterColumn("dbo.KontaktOsoba", "RadnoMesto", c => c.String());
            AlterColumn("dbo.KontaktOsoba", "Prezime", c => c.String());
            AlterColumn("dbo.KontaktOsoba", "Ime", c => c.String());
        }
    }
}
