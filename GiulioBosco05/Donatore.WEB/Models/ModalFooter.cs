namespace Donatore.WEB.Models {
	public class ModalFooter {
		public string SubmitButtonText { get; set; } = "Submit";
		public string CancelButtonText { get; set; } = "Cancel";
		public string SubmitButtonId { get; set; } = "btn-submit";
		public string CancelButtonId { get; set; } = "btn-cancel";
		public bool OnlyCancelButton { get; set; }
	}
}