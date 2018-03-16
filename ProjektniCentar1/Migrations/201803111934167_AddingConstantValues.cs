namespace ProjektniCentar1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingConstantValues : DbMigration
    {
        public override void Up()
        {
            //Ubacivanje konstantnih tipova Mail adrese
            Sql("SET IDENTITY_INSERT OznakaMailAdrese ON");
            Sql("INSERT INTO OznakaMailAdrese (Id, Naziv) VALUES(1, 'Posao')");
            Sql("INSERT INTO OznakaMailAdrese (Id, Naziv) VALUES(2, 'Privatna')");
            Sql("INSERT INTO OznakaMailAdrese (Id, Naziv) VALUES(3, 'Drustvena')");
            Sql("SET IDENTITY_INSERT OznakaMailAdrese OFF");
            //Ubacivanje konstantnih tipova Oznaka Telefona
            Sql("SET IDENTITY_INSERT OznakaTelefon ON");
            Sql("INSERT INTO OznakaTelefon (Id, Naziv) VALUES(1, 'Kancelarija')");
            Sql("INSERT INTO OznakaTelefon (Id, Naziv) VALUES(2, 'Sluzbeni mobilni')");
            Sql("INSERT INTO OznakaTelefon (Id, Naziv) VALUES(3, 'Privatni mobilni')");
            Sql("INSERT INTO OznakaTelefon (Id, Naziv) VALUES(4, 'Fiksni')");
            Sql("SET IDENTITY_INSERT OznakaTelefon OFF");
        }
        
        public override void Down()
        {
        }
    }
}
