using System.Collections.Generic;

namespace Donatore.WEB.Models {
	public class DonatoreIndexViewModel {
		public string Title { get; set; }

		public List<DA.Models.Donatore> Donatori { get; set; }

		public string Ip { get; set; }
	}
}