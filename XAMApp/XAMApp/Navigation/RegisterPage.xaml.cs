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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage()
		{
			InitializeComponent();
		}

		private async void Save_Clicked(object sender, EventArgs e)
		{
			if(await DisplayAlert("Confirm?", "Are you sure you want to save?", "Yes", "No"))
				await Navigation.PopAsync();
		}
	}
}