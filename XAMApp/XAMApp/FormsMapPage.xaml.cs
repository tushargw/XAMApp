using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormsMapPage : ContentPage
	{
		public FormsMapPage()
		{
			InitializeComponent();
		}
	}
}