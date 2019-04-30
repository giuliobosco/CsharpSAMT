using System;

namespace Pallavolo.DA.Models {
	public class Giocatore : BaseEntity {
	
		public string Nome { get; set; }
		
		public string Cognome { get; set; }
		
		public DateTime Nascita { get; set; }
		
		public int numero { get; set; }
	}
}