using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Laurea.DA.Model {
    [Table("Studenti")]
    class Studente {
        [Key]
        public int Id;
        public string Nome;
        public string Cognome;
    }
}
