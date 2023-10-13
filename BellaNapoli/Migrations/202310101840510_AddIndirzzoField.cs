namespace BellaNapoli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIndirzzoField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clienti", "Indirizzo", c => c.String(maxLength: 50));
        }

        public override void Down()
        {
            DropColumn("dbo.Clienti", "Indirizzo");
        }
    }
}
