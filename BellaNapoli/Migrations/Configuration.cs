namespace BellaNapoli.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BellaNapoli.Models.ModelDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BellaNapoli.Models.ModelDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
 /*Html.Hidden("IdProdotti", item.IdProdotti)
  *<div class="form-group"> 
  *<label for="IdAggiunzione"> Aggiunta</label>
  *@Html.DropDownList("IdAggionzione", new SelectList(ViewBag.Aggiunzioni, "Value", "Text"), mew (class= "form - control")*/