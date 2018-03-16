namespace ProjektniCentar1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesFromModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KontaktOsoba",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        RadnoMesto = c.String(),
                        PreduzeceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Preduzece", t => t.PreduzeceId, cascadeDelete: true)
                .Index(t => t.PreduzeceId);
            
            CreateTable(
                "dbo.Preduzece",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivPreduzeca = c.String(),
                        AdresaPreduzeca = c.String(),
                        Opstina = c.String(),
                        PostanskiBroj = c.String(),
                        MaticniBroj = c.String(),
                        PIB = c.String(),
                        BrojRacuna = c.String(),
                        WebStranica = c.String(),
                        Fotografija = c.String(),
                        Beleske = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListaMailAdrese",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MailAdresa = c.String(),
                        OznakaMailAdreseId = c.Int(nullable: false),
                        KontaktOsobaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KontaktOsoba", t => t.KontaktOsobaId, cascadeDelete: true)
                .ForeignKey("dbo.OznakaMailAdrese", t => t.OznakaMailAdreseId, cascadeDelete: true)
                .Index(t => t.OznakaMailAdreseId)
                .Index(t => t.KontaktOsobaId);
            
            CreateTable(
                "dbo.OznakaMailAdrese",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListaTelefon",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Lokal = c.String(),
                        BrojTelefona = c.String(),
                        OznakaTelefonId = c.Int(nullable: false),
                        KontaktOsobaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KontaktOsoba", t => t.KontaktOsobaId, cascadeDelete: true)
                .ForeignKey("dbo.OznakaTelefon", t => t.OznakaTelefonId, cascadeDelete: true)
                .Index(t => t.OznakaTelefonId)
                .Index(t => t.KontaktOsobaId);
            
            CreateTable(
                "dbo.OznakaTelefon",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ListaTelefon", "OznakaTelefonId", "dbo.OznakaTelefon");
            DropForeignKey("dbo.ListaTelefon", "KontaktOsobaId", "dbo.KontaktOsoba");
            DropForeignKey("dbo.ListaMailAdrese", "OznakaMailAdreseId", "dbo.OznakaMailAdrese");
            DropForeignKey("dbo.ListaMailAdrese", "KontaktOsobaId", "dbo.KontaktOsoba");
            DropForeignKey("dbo.KontaktOsoba", "PreduzeceId", "dbo.Preduzece");
            DropIndex("dbo.ListaTelefon", new[] { "KontaktOsobaId" });
            DropIndex("dbo.ListaTelefon", new[] { "OznakaTelefonId" });
            DropIndex("dbo.ListaMailAdrese", new[] { "KontaktOsobaId" });
            DropIndex("dbo.ListaMailAdrese", new[] { "OznakaMailAdreseId" });
            DropIndex("dbo.KontaktOsoba", new[] { "PreduzeceId" });
            DropTable("dbo.OznakaTelefon");
            DropTable("dbo.ListaTelefon");
            DropTable("dbo.OznakaMailAdrese");
            DropTable("dbo.ListaMailAdrese");
            DropTable("dbo.Preduzece");
            DropTable("dbo.KontaktOsoba");
        }
    }
}
