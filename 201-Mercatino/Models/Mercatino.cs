using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _101_Mercatino.Models {
    [Table("Mercatini")]
    public class Mercatino {
        public int Id { get; set; }
        public string Luogo { get; set; }
        public string Nazione { get; set; }
        //public DateTime Inizio { get; set; }
    }
}