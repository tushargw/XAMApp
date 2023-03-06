using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackCustomControl : StackLayout
	{
		private readonly StackViewModel _vm;

		public StackCustomControl()
		{
			InitializeComponent();

			BindingContext = _vm = new StackViewModel();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Result.Text = _vm.Title + ": " +_vm.Description;
		}
	}
}