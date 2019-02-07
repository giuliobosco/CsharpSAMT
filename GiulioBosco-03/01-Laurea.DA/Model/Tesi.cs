using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Laurea.DA.Model {
    [Table("Tesi")]
    public class Tesi {
        [Key]
        public int Id { get; set; }
        public string Titolo { get; set; }
        public List<Studente> Studenti { get; set; }
        public Formatore Relatore { get; set; }
        public Formatore Perito { get; set; }
        public Tipo Tipo { get; set; }
        public Area Area { get; set; }
    }
}
