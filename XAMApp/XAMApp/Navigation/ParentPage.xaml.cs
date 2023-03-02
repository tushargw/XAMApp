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
	public partial class ParentPage : ContentPage
	{
		public ParentPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			var page = new ChildPage();
			page.SliderValueChanged += Page_SliderValueChanged;
			Navigation.PushAsync(page);
		}
		private void Page_SliderValueChanged(object sender, double e)
		{
			label1.Text = e.ToString();
		}
	}
}