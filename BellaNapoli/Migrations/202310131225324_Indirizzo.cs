namespace BellaNapoli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Indirizzo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Indirizzo", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Indirizzo");
        }
    }
}
