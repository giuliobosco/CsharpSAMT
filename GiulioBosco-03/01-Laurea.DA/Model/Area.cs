using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Laurea.DA.Model {
    [Table("Aree")]
    public class Area {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
