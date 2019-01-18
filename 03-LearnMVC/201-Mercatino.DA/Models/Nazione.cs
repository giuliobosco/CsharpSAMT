using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _101_Mercatino.Models;

namespace _201_Mercatino.Models {
    [Table("Nazioni")]
    public class Nazione {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Mercatino> Mercatini { get; set; }
    }
}
