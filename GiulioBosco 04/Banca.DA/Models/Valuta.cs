using System;
using System.Collections.Generic;
using System.Text;

namespace Banca.DA.Models {
    public class Valuta {
        public int Id { get; set; }

        public string Codice { get; set; }

        public string  denominazione { get; set; }

        public double entrata { get; set; }

        public double cambio { get; set; }
    }
}
