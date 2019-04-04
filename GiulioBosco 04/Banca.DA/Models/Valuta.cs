using System;
using System.Collections.Generic;
using System.Text;

namespace Banca.DA.Models {
    public class Valuta {
        public int Id { get; set; }

        public string Codice { get; set; }

        public string  Denominazione { get; set; }

        public double Entrata { get; set; }

        public double Cambio { get; set; }
    }
}
