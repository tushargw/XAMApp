using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LandingPage : ContentPage
	{
		public LandingPage()
		{
			InitializeComponent();

			if (App.Current.Properties.ContainsKey("Username"))
			{
				label1.Text = App.Current.Properties["Username"].ToString();
			}
		}

		private void Logout_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}