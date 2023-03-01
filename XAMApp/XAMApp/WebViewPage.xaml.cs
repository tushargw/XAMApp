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
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage()
		{
			InitializeComponent();

			//myWebView.Source = "https://www.wikipedia.org/";

			//var localhtml = new HtmlWebViewSource();
			//localhtml.Html = @"<html><body><h1>Loca Html redering</h1><p>This is my paragraph</p></body></html>";
			//myHtmlView.Source = localhtml;
		}
	}
}