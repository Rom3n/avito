using avito.BL.ViewModels;

namespace avito.UI.Pages {
	interface IBasePage {
		string Title { get; set; }
		void SetViewModel(BaseViewModel viewModel);
	}
}