namespace BellaNapoli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nome : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Nome", c => c.String(maxLength: 50));
            AddColumn("dbo.User", "Cognome", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Cognome");
            DropColumn("dbo.User", "Nome");
        }
    }
}
