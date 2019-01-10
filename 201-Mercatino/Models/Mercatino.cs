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
        [Key,Column("0")]
        public int Id { get; set; }

        [Column("1")]
        public string Luogo { get; set; }

        [Column("2")]
        public string Nazione { get; set; }
        
        //[Column("3")]
        //public DateTime Inizio { get; set; }
    }
}