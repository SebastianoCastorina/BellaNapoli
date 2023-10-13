using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BellaNapoli.Models
{
    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
            : base("name=ModelDbContext")
        {
        }

        public virtual DbSet<Clienti> Clienti { get; set; }
        public virtual DbSet<DettagliOrdini> DettagliOrdini { get; set; }
        public virtual DbSet<Ordini> Ordini { get; set; }
        public virtual DbSet<Prodotti> Prodotti { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ordini>()
                .Property(e => e.Importo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordini>()
                .HasMany(e => e.DettagliOrdini)
                .WithOptional(e => e.Ordini)
                .HasForeignKey(e => e.IdOrdini);

            modelBuilder.Entity<Ordini>()
                .HasMany(e => e.DettagliOrdini1)
                .WithOptional(e => e.Ordini1)
                .HasForeignKey(e => e.IdOrdini);
        }

        
    }

}
