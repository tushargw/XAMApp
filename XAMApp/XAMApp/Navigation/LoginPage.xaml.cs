using System;
using System.Linq;
using XAMApp.Models;
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
			if (IsUserValid(Username.Text, Password.Text))
			{
				App.Current.Properties["Username"] = Username.Text;
				Navigation.PushAsync(new LandingPage());
				return;
			}

			DisplayAlert("Failure !!", "Username or password is incorrect.", "Retry");
		}

		private bool IsUserValid(string username, string password)
		{
			var rows = (from row in App.Connection.Table<Login>() where row.Username.ToLower() == username.ToLower() && row.Password == password select row).ToList();
			if (rows.Count() == 0)
				return false;

			return true;
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