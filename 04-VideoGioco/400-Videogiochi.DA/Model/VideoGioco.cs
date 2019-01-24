using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _400_Videogiochi.DA.Model {
    [Table("Videogiochi")]
    public class VideoGioco {
        [Key]
        public int Id { get; set; }

        public double Costo { get; set; }

        public DateTime Data { get; set; }

        public string Nome { get; set; }

        public int Record { get; set; }

        public Tipo Tipo { get; set; }
    }
}
