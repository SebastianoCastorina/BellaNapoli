namespace BellaNapoli.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DettagliOrdini")]
    public partial class DettagliOrdini
    {
        [Key]
        public int IdDettagli { get; set; }

        public int? IdProdotti { get; set; }

        public int? Quantita { get; set; }

        public int? IdOrdini { get; set; }

        [StringLength(50)]
        public string TempoConsegna { get; set; }

        public virtual Ordini Ordini { get; set; }

        public virtual Ordini Ordini1 { get; set; }

        public virtual Prodotti Prodotti { get; set; }
    }
}
