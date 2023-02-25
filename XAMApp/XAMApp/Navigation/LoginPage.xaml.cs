using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			if (Username.Text == "admin" && Password.Text == "admin")
			{
				DisplayAlert("Success !!", "You have logged in successfully.", "Ok");
				return;
			}
			DisplayAlert("Failure !!", "Username or password is incorrect.", "Retry");
		}
	}
}