using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _101_Mercatino.Models {
    [Table("Mercatini")]
    public class Mercatino {

        //[Key]
        [Key,Column("Id")]
        public int Id { get; set; }

        [Column("Luogo")]
        public string Luogo { get; set; }

        [Column("Nazione")]
        public string Nazione { get; set; }
        
        //[Column("3")]
        //public DateTime Inizio { get; set; }
    }
}