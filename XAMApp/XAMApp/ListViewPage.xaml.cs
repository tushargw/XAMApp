﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public class Contact
		{
			public string Name { get; set; }
			public string Email { get; set; }
		}

		public ListViewPage()
		{
			InitializeComponent();

			var names = new List<string>
 {
 "Rana",
 "Vishal",
 "Tushar",
 "Ritu" };
			listViewDefault.ItemsSource = names;

			listView.ItemsSource = new List<Contact>
 { new Contact{Name="Rana",Email="rana@gmai.com"},
 new Contact{Name="Tushar",Email="tishar@gmai.com"}, };
		}
	}
}