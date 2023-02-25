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
	public partial class ForgotPasswordPage : ContentPage
	{
		public ForgotPasswordPage()
		{
			InitializeComponent();
		}

		private async void Retrieve_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("Success", "Password sent to the email address.", "Ok");
			await Navigation.PopAsync();
        }
    }
}