using System;

namespace Donatore.DA.Models {
	public abstract class BaseEntitiy {
		public int Id { get; set; }
		public DateTime Added { get; set; }
		public DateTime Modified { get; set; }
		public DateTime Deleted { get; set; }
		public string IPAddress { get; set; }
	}
}