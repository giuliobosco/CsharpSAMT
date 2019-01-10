using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using _201_Mercatino.Models;

namespace _101_Mercatino.Models {
    [Table("Mercatini")]
    public class Mercatino {

        //[Key,Column("Id")]
        [Key]
        public int Id { get; set; }

        //[Column("Luogo")]
        public string Luogo { get; set; }

        //[Column("Nazione")]
        public virtual Nazione Nazione { get; set; }
        //public string Nazione { get; set; }
        
        //[Column("3")]
        //public DateTime Inizio { get; set; }
    }
}