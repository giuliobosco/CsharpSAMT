using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _400_Videogiochi.DA.Model {
    [Table("Tipi")]
    public class Tipo {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<VideoGioco> videogiochi { get; set; }
    }
}
