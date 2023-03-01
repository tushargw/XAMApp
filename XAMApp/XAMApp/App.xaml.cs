using System;
using XAMApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new WebViewPage(); // AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
