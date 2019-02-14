using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Laurea.DA.Model {
    [Table("Tesi")]
    public class Tesi {
        public int Id { get; set; }

        public string Titolo { get; set; }

        public virtual ICollection<Studente> Studenti { get; set; }

        public virtual Formatore Relatore { get; set; }

        public virtual Formatore Perito { get; set; }

        public virtual Tipo Tipo { get; set; }

        public virtual Area Area { get; set; }
    }
}
