using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace XAMApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MVVMCalculatorPage : ContentPage, IView
	{
		private MVVMCalculatorViewModel _vm;

		public MVVMCalculatorPage()
		{
			InitializeComponent();

			BindingContext = _vm = new MVVMCalculatorViewModel(this);
		}

		public async void ShowError(string message)
		{
			await DisplayAlert("Error !", message, "Ok");
		}
	}
}