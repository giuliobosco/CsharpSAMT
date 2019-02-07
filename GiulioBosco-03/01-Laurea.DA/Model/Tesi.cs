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
        public int Id;
        public string Titolo;
        public List<Studente> Studenti;
        public Formatore Relatore;
        public Formatore Perito;
        public Tipo Tipo;
        public Area Area;
    }
}
