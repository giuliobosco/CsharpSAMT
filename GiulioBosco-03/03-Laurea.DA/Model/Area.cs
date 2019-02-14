using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Laurea.DA.Model {
    [Table("Aree")]
    public class Area {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Tesi> Tesi { get; set; }
    }
}
