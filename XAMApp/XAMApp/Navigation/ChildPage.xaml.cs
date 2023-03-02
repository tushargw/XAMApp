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
	public partial class ChildPage : ContentPage
	{
		public event EventHandler<double> SliderValueChanged;

		public ChildPage()
		{
			InitializeComponent();
		}

		private void silder_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			SliderValueChanged?.Invoke(this, e.NewValue);
		}
	}
}