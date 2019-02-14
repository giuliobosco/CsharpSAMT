using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Laurea.DA.Model {
    public class Area {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Tesi> Tesi { get; set; }
    }
}
