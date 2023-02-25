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

		private void Login_Clicked(object sender, EventArgs e)
		{
			if (Username.Text == "admin" && Password.Text == "admin")
			{
				Navigation.PushAsync(new ControlInfo());
				return;
			}

			DisplayAlert("Failure !!", "Username or password is incorrect.", "Retry");
		}

		private void Register_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new RegisterPage());
		}

		private void ForgotPassword_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new ForgotPasswordPage());
		}
	}
}