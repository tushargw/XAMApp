using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMApp.Models;
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
			{
				if (DoesUsernameExist(Username.Text))
				{
					await DisplayAlert("", "Username exists. Choose another.", "OK");
					return;
				}

				var login = new Login() { Username = Username.Text, Password = Password.Text };
				SaveLogin(login);
				await Navigation.PopAsync();
			}
		}

		private static void SaveLogin(Login login)
		{
			App.Connection.Insert(login);
		}

		private bool DoesUsernameExist(string username)
		{
			var rows = (from row in App.Connection.Table<Login>() where row.Username.ToLower() == username.ToLower() select row).ToList();
			if (rows.Count() == 0)
				return false;

			return true;
		}
	}
}