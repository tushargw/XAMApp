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
	public partial class CustomControlPage : ContentPage
	{
		public string MyDescription { get; set; } = "Hello Some of Desc";

		public CustomControlPage()
		{
			InitializeComponent();

			BindingContext = this;
		}
	}
}