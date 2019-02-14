using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Laurea.DA.Model {
    public class Studente {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public virtual Tesi Tesi { get; set; }
    }
}
