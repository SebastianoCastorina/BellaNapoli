namespace BellaNapoli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clienti",
                c => new
                {
                    IdClienti = c.Int(nullable: false, identity: true),
                    Nome = c.String(maxLength: 50),
                    Cognome = c.String(maxLength: 50),
                    Indirizzo = c.String(maxLength: 50),
                })
                .PrimaryKey(t => t.IdClienti);
        }
            
          
        
        public override void Down()
        {
            DropForeignKey("dbo.DettagliOrdini", "IdOrdini", "dbo.Ordini");
            DropForeignKey("dbo.DettagliOrdini", "IdProdotti", "dbo.Prodotti");
            DropForeignKey("dbo.Ordini", "IdClienti", "dbo.Clienti");
            DropIndex("dbo.DettagliOrdini", new[] { "IdOrdini" });
            DropIndex("dbo.DettagliOrdini", new[] { "IdProdotti" });
            DropIndex("dbo.Ordini", new[] { "IdClienti" });
            DropTable("dbo.User");
            DropTable("dbo.Prodotti");
            DropTable("dbo.DettagliOrdini");
            DropTable("dbo.Ordini");
            DropTable("dbo.Clienti");
        }
    }
}
