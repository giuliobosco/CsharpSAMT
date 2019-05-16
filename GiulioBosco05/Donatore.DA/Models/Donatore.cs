using System;

namespace Donatore.DA.Models {
	public class Donatore : BaseEntitiy {
		public string Nome { get; set; }
		public string Indirizzo { get; set; }
		public string Telefono { get; set; }
		public Sangue Sangue { get; set; }
		public DateTime UltimaDonazione { get; set; }
	}
}