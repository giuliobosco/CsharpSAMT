using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Laurea.DA.Model {
    [Table("Formatori")]
    public class Formatore {
        [Key]
        public int Id;
        public string Cognome;
        public string Ente;
        public bool Interno;
    }
}
