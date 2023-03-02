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
	public partial class StylesPage : ContentPage
	{
		public StylesPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			if (!Resources.ContainsKey("buttonBackGroundColor"))
				Resources.Add("buttonBackGroundColor", (Color)App.Current.Resources["buttonBackGroundColor"]);

			Resources["buttonBackGroundColor"] = ((Color)Resources["buttonBackGroundColor"]) == Color.Pink ? Color.Blue : Color.Pink;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			if (!Resources.ContainsKey("DisabledButton"))
				Resources.Add("DisabledButton", (Style)App.Current.Resources["DisabledButton"]);
			((Button)sender).Style = ((Button)sender).Style.BaseResourceKey == "DisabledButton" ? (Style)App.Current.Resources["GoodButton"] : (Style)App.Current.Resources["DisabledButton"];
		}
	}
}