﻿namespace BellaNapoli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prodotti", "Foto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Prodotti", "Foto");
        }
    }
}
