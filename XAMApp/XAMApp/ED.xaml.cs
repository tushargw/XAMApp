using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMApp.EventAndDelegate;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EDPage : ContentPage
	{
		public EDPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			var videoEncoder = new VideoEncoder();
			videoEncoder.VideoEncoded += OnVideoEncoded;

			videoEncoder.Encode(new Image());
		}

		private void OnVideoEncoded(object sender, EventArgs e)
		{
			label.Text = "Video Encoded at " + DateTime.Now.ToString();
		}
	}
}