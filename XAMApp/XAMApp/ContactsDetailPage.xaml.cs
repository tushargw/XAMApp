using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static XAMApp.ListViewPage;

namespace XAMApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsDetailPage : ContentPage
	{
		public ContactsDetailPage(Contact contact)
		{
			InitializeComponent();
			if (contact == null)
			{
				throw new ArgumentNullException();
			}
			this.BindingContext = contact;
		}
	}
}