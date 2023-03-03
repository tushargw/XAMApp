using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

/*
 * Map integration details: 
 * ------------------------
 * https://learn.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/map/
 * 
 * Keytool command run to create the debug store:
 * ----------------------------------------------
 * keytool.exe -list -v -keystore "C:\Users\[USERNAME]\AppData\Local\Xamarin\Mono for Android\debug.keystore" -alias androiddebugkey -storepass android -keypass android
 * 
 * SHA1: A5:E2:AD:22:E4:75:C7:62:84:36:61:8E:04:B1:D6:21:BC:2F:44:DA
 * 
 * Maps SDK API-Key: AIzaSyCkqLioMGO9P3cbJEc0NmzLyS2pmiTemjg
*/

namespace XAMApp
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormsMapPage : ContentPage
	{
		CancellationTokenSource cts;

		public FormsMapPage()
		{
			InitializeComponent();

			Location location;

			//try
			//{
			//	var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
			//	cts = new CancellationTokenSource();
			//	location = Geolocation.GetLocationAsync(request, cts.Token).GetAwaiter().GetResult();
			//}
			//catch (Exception ex)
			//{
				location = Geolocation.GetLastKnownLocationAsync().GetAwaiter().GetResult();
			//}

			if (location != null)
			{
				var position = new Position(location.Latitude, location.Longitude);
				var mapSpan = new MapSpan(position, 0.01, 0.01);
				map.MoveToRegion(mapSpan);
			}
		}

		protected override void OnDisappearing()
		{
			if (cts != null && !cts.IsCancellationRequested)
				cts.Cancel();

			base.OnDisappearing();
		}
	}
}