using avito.DAL.DataServices;
using avito.UI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace avito
{
	public class App : Application
	{
		public App ()
		{
			DialogService.Init(this);
			NavigationService.Init(this);
			DataServices.Init(true);
		}

		protected override void OnStart ()
		{
			NavigationService.Instance.SetMainTabbedPage(AppPages.Main, AppPages.Start, AppPages.Fav, AppPages.Sell, AppPages.Messages, AppPages.Profile);
		}
	}
}

