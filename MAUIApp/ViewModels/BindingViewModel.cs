﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace MAUIApp.ViewModels
{
	public class BindingViewModel : INotifyPropertyChanged
	{
		private string address;
		private string phone;
		private string name;

		public string Name
		{
			get => name; set
			{
				name = value;
				OnPropertyChanged();
			}
		}
		public string Phone
		{
			get => phone; set
			{
				phone = value;
				OnPropertyChanged();
			}
		}
		public string Address
		{
			get => address; set
			{
				address = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propName = null)
		{
			PropertyChanged?.Invoke(this,
				 new PropertyChangedEventArgs(propName));
		}
	}
}
