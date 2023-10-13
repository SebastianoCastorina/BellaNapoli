namespace BellaNapoli.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ordini")]
    public partial class Ordini
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordini()
        {
            DettagliOrdini = new HashSet<DettagliOrdini>();
            DettagliOrdini1 = new HashSet<DettagliOrdini>();
        }

        [Key]
        public int IdOrdini { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataOrdine { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importo { get; set; }

        [StringLength(50)]
        public string Indirizzo { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public int? IdClienti { get; set; }

        public virtual Clienti Clienti { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DettagliOrdini> DettagliOrdini { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DettagliOrdini> DettagliOrdini1 { get; set; }
    }
}
