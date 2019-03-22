using System;
namespace _05_TortaDellaNonna.DA.Models {
    public class Torta {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descrizione { get; set; }

        public string Osservazioni { get; set; }

        public bool TortaDelMese { get; set; }

        public decimal Prezzo { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

    }
}
