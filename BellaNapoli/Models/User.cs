namespace BellaNapoli.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        public int IdUser { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Role { get; set; }
         [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(50)]
        public string Cognome { get; set; }

        [StringLength(50)]
        public string Indirizzo { get; set; }
    }

}
