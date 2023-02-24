using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace XAMApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MVVMPage : ContentPage
	{
		public MVVMPage()
		{
			InitializeComponent();
		}
	}
}