using Xamarin.Forms;

namespace Pages
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new SampleContentPage_CSharp();
			//MainPage = new SampleContentPage_Xaml();
			//MainPage = new SampleCaroulselPage_CSharp();
			//MainPage = new SampleCaroulselPage_Xaml();
			//MainPage = new NavigationPage(new SampleNavigationPage_CSharp());
			//MainPage = new NavigationPage(new SampleNavigationPage_Xaml());
			//MainPage = new SampleTabbedpage_CSharp();
			//MainPage = new SampleTabbedPage_Xaml();
			// MainPage = new SampleMasterDetailPage_CSharp();
			MainPage = new SampleMasterDetailPage_CSharp();

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
