using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ControlInfo : ContentPage
	{
		public ControlInfo()
		{
			InitializeComponent();
		}

		private void Switch_Toggled(object sender, ToggledEventArgs e)
		{
			label.Text= e.Value.ToString();
		}

		private void ContactsMethod_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			var response = ContactsMethod.Items[ContactsMethod.SelectedIndex];
			DisplayAlert("Title", response, "Ok");
		}
	}
}