using System.Threading.Tasks;
using System.Windows.Input;
using avito.DAL.DataObjects;
using avito.DAL.DataServices;

namespace avito.BL.ViewModels.Fav
{
    public class FavViewModel: BaseViewModel
    {
		public SampleDataObject SampleObject {
			get => Get<SampleDataObject>();
			private set => Set(value);
		}

	    public ICommand SampleCommand => MakeCommand(OnSampleCommand);

	    public override async Task OnPageAppearing() {
			State = PageState.Loading;
		    var result = await DataServices.Main.GetSampleDataObject(CancellationToken);
			if (result.IsValid) {
				SampleObject = result.Data;
				State = PageState.Normal;
			}
			else
				State = PageState.Error;
		}

	    async void OnSampleCommand() {
		    await ShowAlert("New alert", "Just a message", "OK");
	    }
    }
}

