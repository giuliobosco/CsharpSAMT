using System;

namespace Pallavolo.DA.Models {
	public class BaseEntity {
		public int Id { get; set; }

		public DateTime Added { get; set; }

		public DateTime Deleted { get; set; }

		public DateTime Modified { get; set; }
		
		
	}
}